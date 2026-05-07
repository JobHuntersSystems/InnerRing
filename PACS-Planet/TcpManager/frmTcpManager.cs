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
using PACS_Common;

namespace TcpManager
{
    public partial class frmTcpManager : Form
    {

        private TcpClientService clientData;
        private TcpServerService serverData;
        public frmTcpManager()
        {
            InitializeComponent();
        }
        #region Helpers
        private void genericInvokeAction(Control ctr, Action act)
        {
            if (ctr.InvokeRequired)
                ctr.Invoke(act);
            else
                act();
        }
        #endregion
        #region Events Tcp
        public void OnMessageReceived(object sender, EventArgs e)
        {
            if(sender is TcpServerService)
            {
                if (e is TcpServerService.MessageEventArgs)
                {
                    var tcp = (TcpServerService.MessageEventArgs)e;
                    genericInvokeAction(pcsConsoleLog, () =>
                    {
                        pcsConsoleLog.AddLog(
                            tcp.Level,
                            tcp.Message
                        );
                    });
                }
                else if (e is TcpServerService.InfoEventArgs)
                {
                    var tcp = (TcpServerService.InfoEventArgs)e;
                    genericInvokeAction(pcsConsoleLog, () =>
                    {
                        pcsConsoleLog.AddLog(
                            tcp.Level,
                            tcp.Message
                        );
                    });
                    SendManagerEvent(tcp.Level, tcp.Message);
                }
            }
            else if(sender is TcpClientService)
            {
                var tcp = (TcpClientService.TcpEventArgs)e;
                genericInvokeAction(pcsConsoleLog, () =>
                {
                    pcsConsoleLog.AddLog(
                        tcp.Level,
                        tcp.Message
                    );
                });
            }
        }
        public void OnProtocolReceived(object sender, EventArgs e)
        {
            var tcp = (TcpServerService.ProtocolEventArgs)e;
            
        }
        #endregion
        #region Event ManagerEvent
        public event EventHandler SendMessage;
        public class ManagerEventArgs : EventArgs
        {
            public string Message { get; set; }
            public LogLevel Level { get; set; }
        }
        protected virtual void OnSendMessage(ManagerEventArgs e)
        {
            if (null != SendMessage)
            {
                SendMessage(this, e);
            }
        }
        private void SendManagerEvent(LogLevel level, string msg)
        {
            this.OnSendMessage(new ManagerEventArgs
            {
                Message = msg,
                Level = level
            });
        }
        #endregion
        #region Form
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (serverData == null)
            {
                serverData = new TcpServerService();
                this.serverData.SendMessage += new EventHandler(OnMessageReceived);
                this.serverData.infoMessage += new EventHandler(OnMessageReceived);
                this.serverData.ProtocolMessage += new EventHandler(OnProtocolReceived);
            }

            if (!serverData.isRunning)
            {
                int portData = int.Parse(txtDataPort.Text);
                serverData.startServer(portData);

                lblServerStatusValue.Text = "● ONLINE";
                lblServerStatusValue.ForeColor = Color.FromArgb(80, 255, 90);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (serverData.isRunning)
            {
                serverData.stopServer();

                lblServerStatusValue.Text = "● OFFLINE";
                lblServerStatusValue.ForeColor = Color.FromArgb(255, 180, 40);
            }
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            string ip = txtPlanetIp.Text;
            if (!string.IsNullOrWhiteSpace(ip))
            {
                clientData = new TcpClientService();
                this.clientData.SendMessage += new EventHandler(OnMessageReceived);

                clientData.checkConnection(ip);
            }

        }
        #endregion
    }
}
