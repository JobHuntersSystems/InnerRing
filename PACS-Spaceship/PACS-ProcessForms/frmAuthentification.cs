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

using System.Security.Cryptography;


namespace PACS_ProcessForms
{
    public partial class frmAuthentification : Form
    {
        TcpClientService tcpClient;
        DataTcpServer tcpServer;

        public frmAuthentification()
        {
            InitializeComponent();
            tcpClient = new TcpClientService();
            tcpServer = new DataTcpServer();

            tcpServer.DataReceived += OnServerDataReceived;
            tcpServer.ServerStatusChanged += OnServerStatusChanged; 
        }
        #region botones proceso
        private void btnPhase1_Click(object sender, EventArgs e)
        {
            btnPhase1.Enabled = false;
            btnPhase2.Enabled = true;

            tcpServer.startServer(ConnectionInfo.PlanetDataPort);
            SendER();
        }

        private void btnPhase2_Click(object sender, EventArgs e)
        {
            btnPhase2.Enabled = false;
            btnPhase3.Enabled = true;
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

            LogToConsole($"INICIANDO PROTOCOLO HANDSHAKE...");
            LogToConsole($"Generando ER: {erMessage}");

            tcpClient.sendMessage(ConnectionInfo.TargetPlanetIP,ConnectionInfo.PlanetDataPort, erMessage);
        }     



        private void LogToConsole(string message)
        {
            string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string logLine = $"[{timeStamp}] {message}";

            if (protocolConsole != null)
            {
                protocolConsole.AddLog(LogLevel.Info, logLine);
            }
        }


        #region eventos de notificación
        private void OnServerDataReceived(object sender, EventArgs e)
        {
            // Extraemos tu clase personalizada DataReceivedEventArgs
            DataTcpServer.DataReceivedEventArgs mensaje = (DataTcpServer.DataReceivedEventArgs)e;

            this.Invoke((MethodInvoker)delegate {
                LogToConsole($"Message from {mensaje.ClientIp}: {mensaje.RawData}");

                // Aquí haces tu lógica de validación
                if (mensaje.RawData.EndsWith("VP"))
                {
                    LogToConsole("Validation Request Succes");
                    btnPhase2.Enabled = true;
                }
                else
                {
                    LogToConsole("Validation Request Denied");
                    btnPhase1.Enabled = true;
                }
            });
        }

        private void OnServerStatusChanged(object sender, EventArgs e)
        {
            // Extraemos tu clase personalizada ServerStatusEventArgs
            var args = (DataTcpServer.ServerStatusEventArgs)e;

            this.Invoke((MethodInvoker)delegate {
                if (args.Status == ServerStatus.Error)
                {
                    LogToConsole($"FALLO TCP: {args.Message}");
                }
                else
                {
                    LogToConsole($"SERVER STATUS: {args.Message}");
                }
            });
        }
        #endregion

        private void frmAuthentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpServer.stopServer();
        }

        private void frmAuthentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            tcpServer.stopServer();
        }
    }
}
