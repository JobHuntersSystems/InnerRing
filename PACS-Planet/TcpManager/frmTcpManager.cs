using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
        
        private void updateCurrentSpaceshipData()
        {
                genericInvokeAction(pctSpaceship, () => {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory , @"Resources\Spaceships\Imagenes\Caza_Tie.png");
                    pctSpaceship.ImageLocation = path;
                    pctSpaceship.Visible = true;
                    lblSpaceshipIpValue.Text = Spaceship.ip;
                });  
        }
        #endregion
        #region Events TCP Gestion
        #region Protocols
        private void raiseErProtocol(string client_ip, string client_message)
        {
            ProtocolResponse response;
            if (Spaceship.CurrentStage == 0)
            {
                Spaceship.ip = client_ip;
                genericInvokeAction(pcsConsoleLog, () =>
                    {
                        pcsConsoleLog.AddLog(LogLevel.Message,
                           $"{client_ip} | {client_message}"
                        );
                        pcsConsoleLog.AddLog(LogLevel.Info,
                           "ER Protocol detected, starting validation..."
                        );
                    }
                );
                response = protocolManager.excuteErProtocol(client_message);
                string console_message;
                if (response.result == ResultType.VP)
                {
                    genericInvokeAction(pcsConsoleLog, () =>
                    {
                        btnCheckConnection.Visible = true;
                        btnAbortProtocol.Visible = true;
                        console_message = "Delivery confirmed, able to the next stage ✅";
                        pcsConsoleLog.AddLog(
                            LogLevel.Success,
                            console_message);
                    });
                    RaiseNotificationSent(Spaceship.CurrentStage, true);
                    clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, response.protocolResponse);
                    updateCurrentSpaceshipData();
                }
                else
                {
                    response = protocolManager.getDefaultDenegationResponse();

                    RaiseNotificationSent(Spaceship.CurrentStage, false);
                    finishingFaildProtocol(response.protocolResponse);
                }
                
          
            }
        }
        private void raiseVkProtocol(string client_ip, string client_message)
        {
            ProtocolResponse response;
            genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                LogLevel.Message,
                $"{client_ip} | {client_message}"
            ));
            response = protocolManager.excuteVkProtocol(client_message);
            string console_message;
            if (response.result == ResultType.VP)
            {
                genericInvokeAction(pcsConsoleLog, () => {
                    btnCheckConnection.Visible = true;

                    console_message = "Validation Code confirmed, able to the next stage ✅";
                    pcsConsoleLog.AddLog(
                        LogLevel.Success,
                        console_message);
                });
                RaiseNotificationSent(Spaceship.CurrentStage, true);
            }
            else
            {
               
                response = protocolManager.getDefaultDenegationResponse();
                RaiseNotificationSent(Spaceship.CurrentStage, false);
            }
           
            if (response.result != ResultType.VP)
            {
                finishingFaildProtocol(response.protocolResponse);
            }
            else
            {
                clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, response.protocolResponse);
                updateCurrentSpaceshipData();
            }
                
        }
        #endregion
        private void OnServerStatusChanged(object sender, EventArgs e)
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
        bool isActiveCheckSumProtocol = false;
        MessageProtocolType currentProtcoltype = MessageProtocolType.VK;
        private void OnDataReceived(object sender, EventArgs e)
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
                    RaiseNotificationSent(Spaceship.CurrentStage, true);
                }

                if (!isActiveVkProtocol)
                {
                    currentProtcoltype = protocolManager.identifyProtocolType(client_message);
                    if(currentProtcoltype == MessageProtocolType.VK && Spaceship.CurrentStage == 1)
                    {
                        genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                                LogLevel.Info,
                                "VK Protocol detected, wating for the next message..."
                        ));
                    }
                }

                switch (currentProtcoltype)
                {
                    case MessageProtocolType.ER:
                        raiseErProtocol(client_ip,client_message);
                        break;
                    case MessageProtocolType.VK:
                        if (isActiveVkProtocol)
                        {
                            raiseVkProtocol(client_ip, client_message);
                            isActiveVkProtocol = false;
                        }
                        else
                        {
                            isActiveVkProtocol = true;
                        }
                        break;
                    case MessageProtocolType.Message:
                        string message = client_ip + "| " + client_message;
                        genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                                LogLevel.Message,
                                message
                        ));
                        break;
                }
                if (isActiveCheckSumProtocol)
                {
                    Spaceship.CheckSum = int.Parse(client_message);
                    RaiseNotificationSent(Spaceship.CurrentStage, true);
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
        private void OnClientServiceNotifyReceived(object sender, EventArgs e)
        {
            var tcp = (TcpClientService.NotificationSentEventArgs)e;
            genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(
                  tcp.Level,
                  tcp.Message
            ));
        }
        #endregion
        #region Public Methods
        public void finishingFaildProtocol(string message)
        {
            string explosionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\gifs\explosion.gif");
            
            genericInvokeAction(pcsConsoleLog, () =>
            {
                if(Spaceship.id != 0 && Spaceship.dataPort!=0)
                {
                    clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, message);
                }

                pctSpaceship.ImageLocation = explosionPath;
                Animation.Start();
                pcsConsoleLog.AddLog(
                    LogLevel.Warn,
                    "Spaceship refused, starting destruction---- > 🚀💥"
                );
               
                Spaceship.Reset();
                btnAbortProtocol.Visible = false;
                btnCheckConnection.Visible = false;
                isActiveCheckSumProtocol = false;
                isActiveVkProtocol = false;
                lblSpaceshipIpValue.Text = "-";
            });
        }
        public void successFinalProtocol(string message)
        {
            genericInvokeAction(pcsConsoleLog, () =>
            {
                clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, message);
               
                pcsConsoleLog.AddLog(
                    LogLevel.Success,
                    $"The Spaceship {Spaceship.code} fullfil succesfully with all requirements. Open gates ✅✅✅"
                );
                
                Spaceship.Reset();
                pctSpaceship.Visible = false;
                btnAbortProtocol.Visible = false;
                btnCheckConnection.Visible = false;
                isActiveCheckSumProtocol = false;
                isActiveVkProtocol = false;
                lblSpaceshipIpValue.Text = "-";
            });
        }
        public void sendZip(string host_ip, int file_port,string zip_path )
        {
            try
            {
                clientData.sendFile(host_ip, file_port, zip_path);
                int port = int.Parse(txtFilePort.Text);
                genericInvokeAction(pcsConsoleLog, () => pcsConsoleLog.AddLog(LogLevel.Info, $"Wating for the Spaceship sum..."));
                isActiveCheckSumProtocol = true;
                Spaceship.CurrentStage += 1;
            }
            catch(Exception ex)
            {
                genericInvokeAction(pcsConsoleLog, () =>
                    {
                        pcsConsoleLog.AddLog(LogLevel.Error, ex.Message);
                    }
                );
            }
            
        }
        public void sendFinalValidation(string host_ip, int file_port, bool validation)
        {
            try
            {
                string message = "VR"+Spaceship.CurrentStage+Spaceship.code;
                if (validation)
                {
                    message += "AG";
                    successFinalProtocol(message);
                }
                else
                {
                    message += "AD";
                    finishingFaildProtocol(message);
                }
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
        private void frmTcpManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataServer != null && dataServer.isRunning)
            {
                dataServer.stopServer();
                Spaceship.Reset();
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
        #endregion
        #region Event NotificationSent
        public event EventHandler NotificationSent;
        public class NotificationSentEventArgs : EventArgs
        {
            public int Stage { get; set; }
            public bool Able { get; set; }
        }

        protected virtual void OnNotificationSent(NotificationSentEventArgs e)
        {
            if (null != NotificationSent)
            {
                NotificationSent(this, e);
            }
        }
        private void RaiseNotificationSent(int stage, bool able)
        {
            this.OnNotificationSent(new NotificationSentEventArgs
            {
                Stage = stage,
                Able = able,
            });
        }

        #endregion

        private void btnAbortProtocol_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you cancel the protocol?",
               "Confirm Close",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (result == DialogResult.Yes)
            {
                string message = "VR" + Spaceship.CurrentStage + Spaceship.code + "AD";
                finishingFaildProtocol(message);
                RaiseNotificationSent(-1, false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to close this window? The protocols opened will be canceled",
                    "Confirm Close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if(!string.IsNullOrWhiteSpace(Spaceship.ip) && Spaceship.dataPort != 0)
                    {
                        string message = "VR" + Spaceship.CurrentStage + Spaceship.code + "AD";
                        this.clientData.NotificationSent -= OnClientServiceNotifyReceived;
                        clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, message);
                        Spaceship.Reset();
                    }
                      
                    RaiseNotificationSent(-1, false);
                    this.Close();
                }
            }catch(Exception ex)
            {

            }
        
        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            try
            {
                Animation.Stop();
                Animation.Dispose();
                pctSpaceship.Visible = false;
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}
