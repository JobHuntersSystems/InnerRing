using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PACS_UI;
using TcpServers;

namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        private PlanetTcpServer planetServer;
        private Thread serverThread;

        private string currentShipId = "";
        private string currentDeliveryId = "";
        private string currentShipIp = "";

        public frmMain()
        {
            InitializeComponent();

            AddLog("Planet Control Center initialized");
            AddLog("Waiting for operator command...");
        }

        private void AddLog(string message, string type = "INFO")
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string line = $"[{timestamp}] [{type.PadRight(5)}] {message}";

            if (type == "ERROR")
                rtbLogs.SelectionColor = Color.Red;
            else if (type == "RECV")
                rtbLogs.SelectionColor = Color.Yellow;
            else if (type == "SUCCESS")
                rtbLogs.SelectionColor = Color.Lime;
            else
                rtbLogs.SelectionColor = Color.LightGreen;

            rtbLogs.AppendText(line + Environment.NewLine);
            rtbLogs.SelectionStart = rtbLogs.Text.Length;
            rtbLogs.ScrollToCaret();
            rtbLogs.SelectionColor = rtbLogs.ForeColor;
        }

        private void btnSecuritySetup_Click(object sender, EventArgs e)
        {
            AddLog("Security Setup page selected.");
        }

        private void StartPlanetServer()
        {
            if (planetServer != null)
            {
                AddLog("Planet TCP/IP server is already running.", "ERROR");
                return;
            }

            AddLog("Starting Planet TCP/IP server...");

            planetServer = new PlanetTcpServer();

            planetServer.MessageReceived += PlanetServer_MessageReceived;

            serverThread = new Thread(() =>
            {
                planetServer.startServer(5000);
            });

            serverThread.IsBackground = true;
            serverThread.Start();

            AddLog("Planet TCP/IP server launched on port 5000.", "SUCCESS");
            AddLog("Waiting for ER message...");
        }

        private void PlanetServer_MessageReceived(string message, string remoteIp)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    OnMessageReceived(message, remoteIp);
                }));
            }
            else
            {
                OnMessageReceived(message, remoteIp);
            }
        }

        private void OnMessageReceived(string message, string remoteIp)
        {
            AddLog("Message received from " + remoteIp + ": " + message, "RECV");

            if (message.StartsWith("ER"))
            {
                HandleER(message, remoteIp);
            }
            else
            {
                AddLog("Message ignored for now. Only ER is handled in Step 1.", "ERROR");
            }
        }

        private void HandleER(string message, string remoteIp)
        {
            AddLog("Processing ER message...");

            if (message.Length != 26)
            {
                AddLog("Invalid ER message length. Expected 26 characters.", "ERROR");
                return;
            }

            currentShipId = message.Substring(2, 12);
            currentDeliveryId = message.Substring(14, 12);
            currentShipIp = remoteIp;

            AddLog("ER message accepted.", "SUCCESS");
            AddLog("Ship ID: " + currentShipId);
            AddLog("Delivery ID: " + currentDeliveryId);
            AddLog("Ship IP: " + currentShipIp);
        }

        private void SimulateER()
        {
            string fakeER = "ERNAVE00000001DELIVERY0001";
            OnMessageReceived(fakeER, "192.168.1.50");

        private void btnSecuritySetup_Click(object sender, EventArgs e)
        {
          
        }
    }
}