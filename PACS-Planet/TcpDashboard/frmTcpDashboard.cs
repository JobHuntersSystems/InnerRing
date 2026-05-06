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

        private Thread clientDataThread;
        private TcpClientService clientData;

        private TcpServerService serverData;
        private Thread serverDataThread;
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
        #region EventClass
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
        #endregion
        #region EventsForm
        private void btnStartServer_Click(object sender, EventArgs e)
        {   
            if (serverData == null)
                serverData = new TcpServerService(cl);

            if (serverData.isRunning == false && serverDataThread == null)
            {
                int portData = int.Parse(txtDataPort.Text);
                serverDataThread = new Thread(() => serverData.startServer(portData));
                serverDataThread.Start();
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (serverDataThread != null)
            {
                serverData.stopServer();
                serverDataThread = null;
            }
        }

        private void frmTcpDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            string ip = txtPlanetIp.Text;
            int port = int.Parse(txtDataPort.Text);
            clientData = new TcpClientService(cl);

            clientDataThread = new Thread(() => clientData.checkConnection(ip));
            clientDataThread.Start();
        }
        #endregion
    }
}
