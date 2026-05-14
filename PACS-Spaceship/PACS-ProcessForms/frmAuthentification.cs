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

namespace PACS_ProcessForms
{
    public partial class frmAuthentification : Form
    {
        TcpClientService tcpClient;
        DataTcpServer tcpServer;
        FileTcpServer tcpFileServer;

        public frmAuthentification()
        {
            InitializeComponent();
            tcpClient = new TcpClientService();
            tcpServer = new DataTcpServer();
            tcpFileServer = new FileTcpServer();

            tcpServer.DataReceived += OnServerDataReceived;
            tcpServer.ServerStatusChanged += OnServerStatusChanged; 
        }

        #region botones proceso
        private void btnPhase1_Click(object sender, EventArgs e)
        {
            btnPhase1.Enabled = false;
            tcpServer.startServer(ConnectionInfo.SpaceShipPort);
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
            btnPhase4.Enabled = true;
        }
        #endregion

        private void  SendER()
        {
            string erMessage = ConnectionInfo.GetERMessage();

            LogToConsole($"INICIANDO PROTOCOLO HANDSHAKE...", LogLevel.Info);
            LogToConsole($"Generando ER: {erMessage}", LogLevel.Info);

            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP,ConnectionInfo.PlanetDataPort, erMessage);
        }     
        private void SendVK()
        {
            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP, ConnectionInfo.PlanetDataPort, "VK");
            string Message = ShipCryptoManager.EncryptWithPublicKey(ConnectionInfo.EncryptedValidationCode, ConnectionInfo.PlanetKey);
            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP, ConnectionInfo.PlanetDataPort, Message);
        }

        private void ExtractFile()
        {
            //
            //ZipFile.ExtractToDirectory()
        }

        #region Message Data
        private void OnServerDataReceived(object sender, EventArgs e)
        {
            DataTcpServer.DataReceivedEventArgs mensaje = (DataTcpServer.DataReceivedEventArgs)e;

            this.Invoke((MethodInvoker)delegate {
                LogToConsole($"Message from {mensaje.ClientIp}: {mensaje.RawData}", LogLevel.Info);

                string msgString = mensaje.RawData;
                string typeMsg = mensaje.RawData.Substring(0, 3);


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
                btnPhase1.Enabled = true;
            }
        }
        private void VR2(string msg)
        {
            if (msg.EndsWith("VP"))
            {
                LogToConsole("VR2: RSA payload decrypted. Validation code match. Validation in progress (VP).", LogLevel.Success);
                btnPhase3.Enabled = true;
            }
            else if (msg.EndsWith("AD"))
            {
                LogToConsole("VR2: ACCESS DENIED. RSA decryption failed or invalid validation code (AD).", LogLevel.Warn);
                btnPhase2.Enabled = true;
            }
        }
        private void VR3(string msg)
        {
            if (msg.EndsWith("AG"))
            {
                LogToConsole("VR3: Hash verification successful. ACCESS GRANTED. Opening planetary shields (AG).", LogLevel.Success);
                btnPhase4.Enabled = true;
            }
            else if (msg.EndsWith("AD"))
            {
                LogToConsole("VR3: ACCESS DENIED. Hash mismatch or file corruption detected (AD).", LogLevel.Warn);
                btnPhase3.Enabled = true;
            }
        }

        private void OnServerStatusChanged(object sender, EventArgs e)
        {
            // Extraemos tu clase personalizada ServerStatusEventArgs
            var args = (DataTcpServer.ServerStatusEventArgs)e;

            this.Invoke((MethodInvoker)delegate {
                if (args.Status == ServerStatus.Error)
                {
                    LogToConsole($"TCP FAILURE: {args.Message}", LogLevel.Warn);
                }
                else
                {
                    LogToConsole($"SERVER STATUS: {args.Message}", LogLevel.Info);
                }
            });
        }
        #endregion
        #region  Message File 

        #endregion
        #region FormClosing 
        private void frmAuthentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpServer.stopServer();
        }

        private void frmAuthentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            tcpServer.stopServer();
        }

        #endregion



        private void LogToConsole(string message, LogLevel log)
        {
                protocolConsole.AddLog(log, message);
        }
    }
}
