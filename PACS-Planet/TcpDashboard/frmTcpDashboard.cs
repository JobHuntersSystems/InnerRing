using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TcpClientServices;
using TcpServerServices;
using EventsClass;

namespace TcpDashboard
{
    public partial class frmTcpDashboard : Form
    {
        private CommunicationEventClass cl = new CommunicationEventClass();
        private TcpServerService server;
        private Thread serverThread;
        public frmTcpDashboard()
        {
            InitializeComponent();
            this.cl.SendMessage += new EventHandler(OnMessageReceived);
        }

        private void genericInvokeAction(Control ctr, Action act)
        {
            if (ctr.InvokeRequired)
                ctr.Invoke(act);
            else
                act();
        }
        public void OnMessageReceived(object sender, EventArgs e)
        {
            var tcp = (CommunicationEventClass.TcpEventArgs)e;

            genericInvokeAction(pcsConsoleLog, () =>
            {
                pcsConsoleLog.AddLog(
                    tcp.Level,
                    $"{tcp.ClientIp} | {tcp.Message}"
                );
            });
        }
        
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (server == null && serverThread == null)
            {
                int port = int.Parse(txtDataPort.Text);

                server = new TcpServerService(cl);
                serverThread = new Thread(() => server.startServer(port));
                serverThread.Start();
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (serverThread.IsAlive)
            {
                server.stopServer();
            }
        }

        private void frmTcpDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serverThread.IsAlive)
            {
                server.stopServer();
            }
        }
    }
}
