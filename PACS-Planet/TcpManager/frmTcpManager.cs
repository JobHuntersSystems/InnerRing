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
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Net;
using ProtocolsManager;
using Inner_DB_Access;

namespace TcpManager
{
    public partial class frmTcpManager : Form
    {

        private TcpClientService clientData;
        private DataTcpServer dataServer;
        //private FileTcpServer fileServer;

        private ProtocolManager protocolManager = new ProtocolManager();

        private string currentClientIP = "";
        public frmTcpManager()
        {
            InitializeComponent();
            clientData = new TcpClientService();
            this.clientData.NotificationSent += new EventHandler(OnClientServiceNotifyReceived);
        }
        #region Helpers
        private string GetLocalIp()
        {
            string local_ip = "";
            string hostName = Dns.GetHostName();
            IPHostEntry localhost = Dns.GetHostEntry(hostName);

            IPAddress localIp = localhost.AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            if(localIp != null)
            {
                local_ip  = localIp.ToString();
            }
            return local_ip;
        }
        private void genericInvokeAction(Control ctr, Action act)
        {
            if (ctr.InvokeRequired)
                ctr.Invoke(act);
            else
                act();
        }
        
        private void updateClientData(ResultType result, string protocol, string last_message)
        {
            if(result == ResultType.VP)
            {
                genericInvokeAction(pctSpaceship, () => {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Resources\Spaceships\Imagenes", Spaceship.imagePath);
                    pctSpaceship.ImageLocation = path;
                    pctSpaceship.Visible = true;
                    lblCurrentRequestValue.Text = protocol;
                    lblSpaceshipIpValue.Text = Spaceship.ip;
                    lblLastMessageValue.Text = last_message;
                });
            }
            else if(result == ResultType.AD) 
            {
                Spaceship.Reset();
            }   
        }
        #endregion
        
        #region Events TCP Gestion
        public void OnServerStatusChanged(object sender, EventArgs e)
        {
            var tcp = (DataTcpServer.ServerStatusEventArgs)e;
            LogLevel logL = LogLevel.Info;

            if(tcp.Status == ServerStatus.Error)
            {
                logL = LogLevel.Error;
            }
            else if (tcp.Status == ServerStatus.Starting)
            {
                logL = LogLevel.Info;
            }
            else if (tcp.Status == ServerStatus.Closing)
            {
                logL = LogLevel.Warn;
            }
            else
            {
                logL = LogLevel.Debug;
            }
            genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                    logL,
                    tcp.Message
            ));
            
        }
        
        bool isActiveVkProtocol = false;
        public void OnDataReceived(object sender, EventArgs e)
        {
            try
            {
                var tcp = (DataTcpServer.DataReceivedEventArgs)e;
                string client_ip = tcp.ClientIp;
                string client_message = tcp.RawData;

                //Identificamos si el cliente es conocido o no
                if (string.IsNullOrWhiteSpace(currentClientIP))
                {
                    string message = $"new Spaceship requesting to enter: {client_ip}";
                    currentClientIP = client_ip;
                    RaiseNotificationSent(LogLevel.Warn, message);
                }
                
                if (!isActiveVkProtocol)
                {
                    MessageProtocolType type = protocolManager.identifyProtocolType(client_message);
                    switch (type)
                    {
                        case MessageProtocolType.ER:
                            if(Spaceship.CurrentStage == 0)
                            {
                                ProtocolResponse response;
                                Spaceship.ip = client_ip;
                                genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                                       LogLevel.Info,
                                       "ER Protocol detected, starting validation..."
                                ));
                                response = protocolManager.excuteErProtocol(client_message);
                                string console_message;
                                if (response.result == ResultType.VP)
                                {
                                    genericInvokeAction(pcsConsoleLog, () => {
                                        btnCheckConnection.Visible = true;
                                        console_message = "Delivery confirmed, able to the next stage ✅";
                                        pcsConsoleLog.AddLog(
                                            LogLevel.Success,
                                            console_message);
                                    });
                                }
                                else
                                {
                                    genericInvokeAction(pcsConsoleLog, () =>
                                    {
                                        console_message = "Delivery refused, starting destruction ----> 🚀💥";
                                        pcsConsoleLog.AddLog(
                                            LogLevel.Warn,
                                            console_message
                                        );
                                    });
                                }
                                genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                                    LogLevel.Info,
                                    $"Sending: {response.protocolResponse}"
                                ));
                                clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, response.protocolResponse);
                                updateClientData(response.result, "ER", client_message);
                            }
                            break;
                        case MessageProtocolType.VK:
                            if (Spaceship.CurrentStage == 1)
                            {
                                isActiveVkProtocol = true;
                                genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                                      LogLevel.Info,
                                      "VK Protocol detected, wating for the next message..."
                                ));
                            }
                            break;
                        case MessageProtocolType.Message:
                            string message = client_ip + "| " + client_message;
                            genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                                   LogLevel.Info,
                                   message
                           ));
                            break;
                    }
                }
                else
                {
                    ProtocolResponse response;
                    Spaceship.ip = client_ip;
                    genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                        LogLevel.Info,
                        $"{client_ip} | {client_message}"
                    ));
                    response = protocolManager.excuteVkProtocol(client_message);
                    string console_message;
                    if (response.result == ResultType.VP)
                    {
                        genericInvokeAction(pcsConsoleLog, () => {
                            btnCheckConnection.Visible = true;
                            
                            console_message = "Delivery confirmed, able to the next stage ✅";

                            pcsConsoleLog.AddLog(
                                LogLevel.Success,
                                console_message);
                        });
                    }
                    else
                    {
                        genericInvokeAction(pcsConsoleLog, () =>
                        {
                            console_message = "Delivery refused, starting destruction ----> 🚀💥";
                          
                            pcsConsoleLog.AddLog(
                                LogLevel.Warn,
                                console_message
                            );
                        });
                    }
                    genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                        LogLevel.Info,
                        $"Sending: {response.protocolResponse}"
                    ));
                    clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, response.protocolResponse);
                    updateClientData(response.result ,"VK", client_message);
                    Spaceship.Reset();
                }
            }
            catch (SqlException ex)
            {
                genericInvokeAction(pcsConsoleLog, () =>
                {
                    pcsConsoleLog.AddLog(LogLevel.Error, ex.Message);
                }
                );
            }
            catch (Exception ex)
            {
                genericInvokeAction(pcsConsoleLog, () =>
                {
                    pcsConsoleLog.AddLog(LogLevel.Error, ex.Message);
                }
                );
            }
        }
        public void OnClientServiceNotifyReceived(object sender, EventArgs e)
        {
            var tcp = (TcpClientService.NotificationSentEventArgs)e;
            genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                  tcp.Level,
                  tcp.Message
          ));
        }
        #endregion
        #region Form Events
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (dataServer == null)
            {
                dataServer = new DataTcpServer();
                this.dataServer.ServerStatusChanged += new EventHandler(OnServerStatusChanged);
                this.dataServer.DataReceived += new EventHandler(OnDataReceived);
            }

            if (!dataServer.isRunning)
            {
                int portData = int.Parse(txtDataPort.Text);
                dataServer.startServer(portData);

                lblServerStatusValue.Text = "● ONLINE";
                lblServerStatusValue.ForeColor = Color.FromArgb(80, 255, 90);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (dataServer.isRunning)
            {
                dataServer.stopServer();

                lblServerStatusValue.Text = "● OFFLINE";
                lblServerStatusValue.ForeColor = Color.FromArgb(255, 180, 40);
            }
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            string ip = Spaceship.ip;
            if (!string.IsNullOrWhiteSpace(ip))
            {
                clientData.checkConnection(ip);
            }

        }
        private void frmTcpManager_Load(object sender, EventArgs e)
        {
            string current_Ip = GetLocalIp();
            if(!string.IsNullOrWhiteSpace(current_Ip))
                Planet.IPPlanet = current_Ip;

            txtPlanetIp.Text = Planet.IPPlanet;
            txtDataPort.Text = Planet.PortPlanet;
            txtFilePort.Text = Planet.PortPlanet1;

            lblIPPlanetValue.Text = Planet.IPPlanet;
            lblDataPortValue.Text = Planet.PortPlanet;
            lblFilePortValue.Text = Planet.PortPlanet1;
            lblPlanetName.Text = Planet.DescPlanet.ToUpper();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Resources\Planets", Planet.PlanetPicture);
            pctPlanet.ImageLocation = path;
        }
        #endregion
        #region Event NotificationSent
        public event EventHandler NotificationSent;
        public class NotificationSentEventArgs : EventArgs
        {
            public LogLevel Level { get; set; }
            public string Message { get; set; }
        }

        protected virtual void OnNotificationSent(NotificationSentEventArgs e)
        {
            if (null != NotificationSent)
            {
                NotificationSent(this, e);
            }
        }
        private void RaiseNotificationSent(LogLevel level,string message)
        {
            this.OnNotificationSent(new NotificationSentEventArgs
            {
                Message = message,
                Level = level
            });
        }
        #endregion

        private void frmTcpManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataServer != null && dataServer.isRunning)
            {
                dataServer.stopServer();
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                DB_CRUD dbManager = new DB_CRUD();
                string sql = "UPDATE Planets " +
                      $"SET IPPlanet = '{Planet.IPPlanet}' " +
                      $"WHERE idPlanet = {Planet.idPlanet}";

                dbManager.Executa(sql);
                pcsConsoleLog.AddLog(LogLevel.Success, "Ip Planet Updated !!");
            
            }
            catch (SqlException ex)
            {
                pcsConsoleLog.AddLog(LogLevel.Error, ex.Message);
            } 
            catch (Exception ex)
            {
                pcsConsoleLog.AddLog(LogLevel.Error, ex.Message);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
