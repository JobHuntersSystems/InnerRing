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
using Inner_DB_Access;
using System.Data.SqlClient;

namespace TcpManager
{
    public partial class frmTcpManager : Form
    {

        private TcpClientService clientData;
        private TcpServerService serverData;

        private DB_CRUD dbManger;
        public frmTcpManager()
        {
            InitializeComponent();
            clientData = new TcpClientService();
            this.clientData.SendMessage += new EventHandler(OnMessageReceived);
        }
        #region Helpers
        private void genericInvokeAction(Control ctr, Action act)
        {
            if (ctr.InvokeRequired)
                ctr.Invoke(act);
            else
                act();
        }
        private List<string> decodeMessage(MessageType type, string message)
        {
            List<string> code_parts = new List<string>();
            if (type == MessageType.ER)
            {
                string spaceship_code = message.Substring(2, 12);
                string delivery_code = message.Substring(14, 12);

                code_parts.Add(spaceship_code);
                code_parts.Add(delivery_code);
            }

            return code_parts;
        }
        #endregion
        private ResultType validateDelivery(string spaceship_code, string delivery_code, string ip_spaceship)
        {
            ResultType result = ResultType.AD;
            DataSet db;
 
            //Creamos una instacia del manager
            if (dbManger == null)
                dbManger = new DB_CRUD();

            //Buscamos en la db la información de la nace
            string query = "SELECT *" +
                "FROM SpaceShips " +
                $"WHERE CodeSpaceShip = '{spaceship_code}';";

            db = dbManger.PortarPerConsulta(query);
            //Agregamos todos los datos de la nave
            if (db.Tables[0] != null)
            {
                var table = db.Tables[0];
                Spaceship.id = int.Parse(table.Rows[0]["idSpaceShip"].ToString());
                Spaceship.code = table.Rows[0]["CodeSpaceShip"].ToString();
                Spaceship.dataPort = int.Parse(table.Rows[0]["PortSpaceShip"].ToString());
                Spaceship.filePort = int.Parse(table.Rows[0]["PortSpaceShip1"].ToString());
                Spaceship.ip = ip_spaceship;
                Spaceship.imagePath = table.Rows[0]["SpaceshipImage"].ToString();
            }
            //Buscamos en la db si hay alguna entrega agendada con el DeliveryCode y SpaceShipCode recibidos 
            query = "SELECT *" +
                "FROM DeliveryData " +
                $"WHERE idPlanet = '{Spaceship.id}'" +
                $"AND CodeDelivery = '{delivery_code}';";

            db = dbManger.PortarPerConsulta(query);
            //Si se encuentra algun registro, devolvemos una respuesta afirmativa
            if (db.Tables[0] != null)
                result = ResultType.VP;

            return result;
        }
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

            MessageType type = tcp.MessageType;
            string spaceship_code = "";
            string delivery_code = "";
            try
            {
                if (type == MessageType.ER)
                {
                    string message_response = "VR";
                    string number_response = "1";


                    var message_decoded = decodeMessage(type, tcp.RawData);
                    spaceship_code = message_decoded[0];
                    delivery_code = message_decoded[1];


                    ResultType result = validateDelivery(spaceship_code, delivery_code, tcp.HostIp);

                    //Construimos el mensaje para enviar ====>
                    if (result == ResultType.VP)
                    {
                        message_response += number_response + spaceship_code + "VP";
                    }
                    else
                    {
                        message_response += number_response + spaceship_code + "AD";
                    }

                    clientData.sendMessage(Spaceship.ip, Spaceship.dataPort, message_response);
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
                clientData.checkConnection(ip);
            }

        }
        #endregion
    }
}
