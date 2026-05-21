using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PACS_Common;
using PACS_SpaceShips_Common;
using TcpClientServices;
using TcpServerServices;
using SpaceShip_Encryption;
using System.Threading;
using PACS_Services;
using System.IO;
using Inner_DB_Access;

namespace PACS_ProcessForms
{
    public partial class frmAuthentification : Form
    {
        private readonly TcpClientService tcpClient;
        private readonly DataTcpServer tcpServer;
        private readonly FileTcpServer tcpFileServer;
        private string finalChecksum;
        private string filePath;

        public frmAuthentification()
        {
            InitializeComponent();
            tcpClient = new TcpClientService();
            tcpServer = new DataTcpServer();
            tcpFileServer = new FileTcpServer();

            tcpServer.startServer(ConnectionInfo.SpaceShipPort);
            tcpClient.NotificationSent += new EventHandler(ClientHelper);
            tcpFileServer.ServerStatusChanged += FileOnServerStatusChanged;
            tcpFileServer.FileReceived += RaiseFileReceived;
            tcpServer.DataReceived += OnServerDataReceived;
            tcpServer.ServerStatusChanged += OnServerStatusChanged;
        }

        private void genericInvokeAction(Control ctr, Action act)
        {
            if (ctr.InvokeRequired)
                ctr.Invoke(act);
            else
                act();
        }

        #region botones proceso
        private void btnPhase1_Click(object sender, EventArgs e)
        {
            btnPhase1.Enabled = false;
            SendER();
        }

        private void btnPhase2_Click(object sender, EventArgs e)
        {
            btnPhase2.Enabled = false;
            tcpFileServer.startServer(ConnectionInfo.SpaceShipPort1);
            SendVK();
        }

        private void btnPhase3_Click(object sender, EventArgs e)
        {
            btnPhase3.Enabled = false;
            CalculateCheckSum();
        }

        private void btnPhase4_Click(object sender, EventArgs e)
        {
            btnPhase4.Enabled = false;
            SendChecksum();
        }
        #endregion

        private void SendER()
        {
            string erMessage = ConnectionInfo.GetERMessage();

            LogToConsole($"INICIANDO PROTOCOLO HANDSHAKE...", LogLevel.Info);
            LogToConsole($"Generando ER: {erMessage}", LogLevel.Info);

            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP,ConnectionInfo.PlanetDataPort, erMessage);
        }     
        private void SendVK()
        {
            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP, ConnectionInfo.PlanetDataPort, "VK");
            string encryptedMessage = ShipCryptoManager.EncryptWithPublicKey(ConnectionInfo.EncryptedValidationCode, ConnectionInfo.PlanetKey);
            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP, ConnectionInfo.PlanetDataPort, encryptedMessage);
        }

        private void CalculateCheckSum()
        {
            Thread thread = new Thread(()=> UnZipFolderAndCalculateCheckSum());
            thread.IsBackground = true;
            thread.Start(); 
        }

        private void SendChecksum()
        {
            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP, ConnectionInfo.PlanetDataPort, finalChecksum);
        }

        private void UnZipFolderAndCalculateCheckSum()
        {
            Dictionary<char, string> diccionary = GetCodificationDictionaryFromDatabase();
            PacsZipService zipService = new PacsZipService();
            PacsChecksumService checksumService = new PacsChecksumService();

            PacsZipService.PacsZipExtractResult resultadoExtraccion = zipService.ExtractPacsZip(filePath);

            string[] archivosExtraidos = Directory.GetFiles(resultadoExtraccion.ExtractFolder, "*.txt", SearchOption.AllDirectories);
            int totalGlobalChecksum = 0;

            Parallel.ForEach(archivosExtraidos, filePath =>
            {
                int checksumIndividual = checksumService.CalculateFileChecksum(filePath, diccionary);
                Interlocked.Add(ref totalGlobalChecksum, checksumIndividual);
            });
            
            this.Invoke((MethodInvoker)delegate {
                LogToConsole("UnZip And Calculation Compleated: " + totalGlobalChecksum, LogLevel.Success);
                finalChecksum = totalGlobalChecksum.ToString();
                btnPhase4.Enabled = true;
            });

            string extractFolder = Path.GetDirectoryName(filePath);
            if (Directory.Exists(extractFolder))
            {
                Directory.Delete(extractFolder, true);
            }
        }
        
        private Dictionary<char, string> GetCodificationDictionaryFromDatabase()
        {
            Dictionary<char, string> codification = new Dictionary<char, string>();

            DB_CRUD db = new DB_CRUD();

            int idPlanet = Planet.idPlanet;

            if (idPlanet <= 0)
            {
                throw new Exception("No valid planet selected. Planet.idPlanet is empty or invalid.");
            }

            // Consulta que obtiene el diccionario de codificación:
            // Word = letra
            // Numbers = código numérico de 3 dígitos.
            string query =
                "SELECT d.Word, d.Numbers " +
                "FROM InnerEncryptionData d " +
                "INNER JOIN InnerEncryption e " +
                "ON d.idInnerEncryption = e.idInnerEncryption " +
                "WHERE e.idPlanet = " + idPlanet;

            DataTable dt = db.PortarDataTable(query);

            if (dt.Rows.Count == 0)
            {
                throw new Exception("No codification data found for planet ID " + idPlanet + ".");
            }

            foreach (DataRow row in dt.Rows)
            {
                string wordValue = row["Word"].ToString();
                string numberValue = row["Numbers"].ToString();

                if (string.IsNullOrWhiteSpace(wordValue))
                {
                    throw new Exception("A codification row has an empty Word value.");
                }

                if (string.IsNullOrWhiteSpace(numberValue))
                {
                    throw new Exception("A codification row has an empty Numbers value.");
                }

                char letter = char.ToUpper(wordValue[0]);

                if (numberValue.Length != 3)
                {
                    throw new Exception(
                        "Invalid number code for letter '" + letter + "'. Expected exactly 3 digits."
                    );
                }

                foreach (char digit in numberValue)
                {
                    if (!char.IsDigit(digit))
                    {
                        throw new Exception(
                            "Invalid number code for letter '" + letter + "'. Only digits are allowed."
                        );
                    }
                }

                if (codification.ContainsKey(letter))
                {
                    throw new Exception("Duplicated codification letter found: " + letter);
                }

                codification.Add(letter, numberValue);
            }

            if (codification.Count != 26)
            {
                throw new Exception(
                    "Codification dictionary must contain 26 letters. Current count: " + codification.Count
                );
            }

            return codification;
        }

        private void ClientHelper(object sender, EventArgs e)
        {
            var tcp = (TcpClientService.NotificationSentEventArgs)e;
            genericInvokeAction(protocolConsole, () => protocolConsole.AddLog(
                  tcp.Level,
                  tcp.Message
          ));
        }

        public void FileOnServerStatusChanged(object sender, EventArgs e)
        {
            var tcp = (FileTcpServer.ServerStatusEventArgs)e;
            LogLevel logL = GetLogLevelByStatus(tcp.Status);

            genericInvokeAction(protocolConsole, () => protocolConsole.AddLog(
                    logL,
                    tcp.Message
            ));

        }

        #region Message Data
        private void OnServerDataReceived(object sender, EventArgs e)
        {
            DataTcpServer.DataReceivedEventArgs mensaje = (DataTcpServer.DataReceivedEventArgs)e;

            this.Invoke((MethodInvoker)delegate {
                LogToConsole($"Message from {mensaje.ClientIp}: {mensaje.RawData}", LogLevel.Info);

                string msgString = mensaje.RawData;
                if (string.IsNullOrWhiteSpace(msgString) || msgString.Length < 3)
                {
                    LogToConsole("Invalid message received: empty payload or unknown format.", LogLevel.Warn);
                    return;
                }

                string typeMsg = msgString.Substring(0, 3);


                switch (typeMsg)
                {
                    case "VR1":
                        VR1(msgString);
                        break;
                    case "VR2":
                        VR2(msgString);
                        break;
                    case "VR3":
                        VR3(msgString);
                        break;
                    default:
                        break;
                }
            });
        }

        private void VR1(string msg)
        {
            if (msg.EndsWith("VP"))
            {
                LogToConsole("VR1: Handshake successful. Credentials verified in Secure Core. Validation in progress (VP).", LogLevel.Success);
                btnPhase2.Enabled = true;
            }
            else if(msg.EndsWith("AD"))
            {
                LogToConsole("VR1: ACCESS DENIED. Invalid Ship ID or Delivery Code. Connection aborted (AD).", LogLevel.Warn);
                cancelProces();

            }
        }
        private void VR2(string msg)
        {
            if (msg.EndsWith("VP"))
            {
                LogToConsole("VR2: RSA payload decrypted. Validation code match. Validation in progress (VP).", LogLevel.Success);
                LogToConsole("Wating for zip...", LogLevel.Info);
            }
            else if (msg.EndsWith("AD"))
            {
                LogToConsole("VR2: ACCESS DENIED. RSA decryption failed or invalid validation code (AD).", LogLevel.Warn);
                cancelProces();
            }
        }
        private void VR3(string msg)
        {
            if (msg.EndsWith("AG"))
            {
                LogToConsole("VR3: Hash verification successful. ACCESS GRANTED. Opening planetary shields (AG).", LogLevel.Success);
            }
            else if (msg.EndsWith("AD"))
            {
                LogToConsole("VR3: ACCESS DENIED. Hash mismatch or file corruption detected (AD).", LogLevel.Warn);
                cancelProces();
            }
        }

        private void OnServerStatusChanged(object sender, EventArgs e)
        {
            // Extraemos tu clase personalizada ServerStatusEventArgs
            var tcp = (DataTcpServer.ServerStatusEventArgs)e;
            LogLevel logL = GetLogLevelByStatus(tcp.Status);
            genericInvokeAction(protocolConsole, () => protocolConsole.AddLog(
                  logL,
                  tcp.Message
          ));
        }
        #endregion
        #region  Message File 
        private void RaiseFileReceived(object sender, EventArgs e)
        {
            FileTcpServer.DataReceivedEventArgs data = (FileTcpServer.DataReceivedEventArgs)e;
            genericInvokeAction(protocolConsole, () => protocolConsole.AddLog(
                    LogLevel.Info,
                    $"Message from {data.ClientIp}: Dowloaded at {data.FilePath}"
            ));
            this.Invoke((MethodInvoker)delegate
            {
                filePath = data.FilePath;
                btnPhase3.Enabled = true;
            });

        }
        #endregion
        #region FormClosing 
        private void frmAuthentification_FormClosing(object sender, FormClosingEventArgs e)
        {

            tcpServer.stopServer();
            tcpFileServer.stopServer();
        }

        private void frmAuthentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            tcpServer.stopServer();
            tcpFileServer.stopServer();

        }

        #endregion



        private void LogToConsole(string message, LogLevel log)
        {
            protocolConsole.AddLog(log, message);
        }

        private LogLevel GetLogLevelByStatus(ServerStatus status)
        {
            if (status == ServerStatus.Error)
            {
                return LogLevel.Error;
            }

            if (status == ServerStatus.Starting)
            {
                return LogLevel.Info;
            }

            if (status == ServerStatus.Closing)
            {
                return LogLevel.Warn;
            }

            return LogLevel.Debug;
        }

        private void cancelProces()
        {
            Application.Exit();
        }

        private void lblAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
