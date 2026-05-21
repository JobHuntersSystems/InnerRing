using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using PACS_Common;
using PACS_SpaceShips_Common;
using Inner_DB_Access;

namespace PACS_ProcessForms
{
    public partial class frmConnection : Form
    {
        #region Initialization

        public frmConnection()
        {
            InitializeComponent();
            InitializeRadar();

            txtShipID.Text = "IS-789456789";
            txtDeliveryID.Text = "123456123456";

        }

        private void InitializeRadar()
        {
            GetPlanetsInfo();
            btnProceed.Enabled = false;
            txtShipID.Text = ConnectionInfo.ShipID;
            txtDeliveryID.Text = ConnectionInfo.DeliveryID;

            LogToConsole("RADAR SYSTEM INITIALIZED. AWAITING TARGET SELECTION.");

        }

        #endregion

        #region UI Events

        private void btnPing_Click(object sender, EventArgs e)
        {
             ExecutePing(ConnectionInfo.TargetPlanetIP);
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShipID.Text) || string.IsNullOrWhiteSpace(txtDeliveryID.Text))
            {
                MessageBox.Show("Please enter valid Ship ID and Delivery ID to proceed.", "Authorization Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ConnectionInfo.TargetPlanetIP))
            {
                MessageBox.Show("Please ping a valid target before proceeding.", "Target Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConnectionInfo.ShipID = txtShipID.Text.Trim();
            ConnectionInfo.DeliveryID = txtDeliveryID.Text.Trim();

            LogToConsole("CREDENTIALS SAVED. INITIATING PROTOCOL TRANSFER...");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtShipID_Validated(object sender, EventArgs e)
        {
            GetSpaceShipInfo();
        }

        #endregion

        #region Data Access

        private void GetPlanetsInfo()
        {
            try
            {
                DB_CRUD db = new DB_CRUD();
                string consulta = "SELECT p.idPlanet, CodePlanet, IPPlanet, PortPlanet, PortPlanet1, k.XMLKey, i.ValidationCode " +
                                  "FROM Planets p, PlanetKeys k, InnerEncryption i " +
                                  "where p.idPlanet = k.idPlanet and i.idPlanet = p.idPlanet";
                DataTable dtPlanetas = db.PortarDataTable(consulta);

                if (dtPlanetas.Rows.Count > 0)
                {
                    cmbTargetIP.DataSource = dtPlanetas;
                    cmbTargetIP.DisplayMember = "CodePlanet";
                    cmbTargetIP.ValueMember = "IPPlanet";

                    SaveSelectedPlanetInfo();
                    btnProceed.Enabled = false;
                    UpdateStatus("● STANDBY / AWAITING PING", Color.FromArgb(100, 100, 100));
                }
            }
            catch (Exception ex)
            {
                LogToConsole($"DB Connection Error: {ex.Message}");
            }
        }

        private void GetSpaceShipInfo()
        {
            try
            {
                DB_CRUD db = new DB_CRUD();
                string consulta = "Select PortSpaceShip, PortSpaceShip1 " +
                                  "from SpaceShips " +
                                  $"where CodeSpaceShip = '{txtShipID.Text.ToString()}'";

                DataTable dtSpaceShip = db.PortarDataTable(consulta);

                if (dtSpaceShip.Rows.Count > 0)
                {
                    int portDataSpaceShip = Convert.ToInt32(dtSpaceShip.Rows[0]["PortSpaceShip"]);
                    int portFileSpaceShip = Convert.ToInt32(dtSpaceShip.Rows[0]["PortSpaceShip1"]);

                    ConnectionInfo.SpaceShipPort = portDataSpaceShip;
                    ConnectionInfo.SpaceShipPort1 = portFileSpaceShip;
                }
                else
                {
                    LogToConsole("DB Connection Error: Not valid SpaceShip code");
                }
            }
            catch (Exception ex)
            {
                LogToConsole($"DB Connection Error: {ex.Message}");
            }
        }

        #endregion

        #region Ping Workflow

        private void ExecutePing(string ipAddress)
        {
            GetSpaceShipInfo();
            SetPingInProgressState();
            LogToConsole($"Sending ICMP Echo Request to {ipAddress}...");

            try
            {
                using (Ping pingSender = new Ping())
                {
                    PingReply reply = pingSender.Send(ipAddress, 3000);
                    ProcessPingReply(reply);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("● SCANNER ERROR", Color.FromArgb(255, 45, 85));
                LogToConsole($"System Error: {ex.Message}");
            }
            finally
            {
                btnPing.Enabled = true;
            }
        }

        private void ProcessPingReply(PingReply reply)
        {
            if (reply.Status != IPStatus.Success)
            {
                UpdateStatus("● TARGET UNREACHABLE", Color.FromArgb(255, 45, 85));
                LogToConsole($"Ping failed: {reply.Status}");
                return;
            }

            UpdateStatus("● UPLINK ESTABLISHED", Color.FromArgb(0, 255, 100));
            LogToConsole($"Reply from {reply.Address}: time={reply.RoundtripTime}ms");
            LogToConsole("TARGET ACQUIRED. COMMLINK READY.");
            btnProceed.Enabled = true;
        }

        private void SetPingInProgressState()
        {
            btnPing.Enabled = false;
            btnProceed.Enabled = false;
            UpdateStatus("● PINGING TARGET...", Color.FromArgb(242, 214, 75));
        }

        private void UpdatePlanetLabels(string ipAddress, int dataPort, int filePort)
        {
            lblPlanetIPValue.Text = ipAddress;
            lblDataPortValue.Text = dataPort.ToString();
            lblFilePortValue.Text = filePort.ToString();
        }

        private void SaveSelectedPlanetInfo()
        {
            string ipAddress;
            string planetKey;
            int dataPort;
            int filePort;
            string validationCode;

            if (!(cmbTargetIP.SelectedItem is DataRowView row))
            {
                return;
            }

            ipAddress = row["IPPlanet"].ToString().Trim();

            if (!int.TryParse(row["PortPlanet"].ToString(), out dataPort)
                || !int.TryParse(row["PortPlanet1"].ToString(), out filePort))
            {
                LogToConsole("DB Connection Error: Invalid target ports in selected planet row.");
                return;
            }

            planetKey = row["XMLKey"] == DBNull.Value ? string.Empty : row["XMLKey"].ToString();
            validationCode = row["ValidationCode"] == DBNull.Value ? string.Empty : row["ValidationCode"].ToString();

            ConnectionInfo.TargetPlanetIP = ipAddress;
            ConnectionInfo.PlanetDataPort = dataPort;
            ConnectionInfo.PlanetFilePort = filePort;
            ConnectionInfo.PlanetKey = planetKey;
            ConnectionInfo.EncryptedValidationCode = validationCode;
            UpdatePlanetLabels(ipAddress, dataPort, filePort);
        }
        #endregion

        #region Visual and Logs

        private void UpdateStatus(string message, Color color)
        {
            lblStatusValue.Text = message;
            lblStatusValue.ForeColor = color;
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

        #endregion
        private void cmbTargetIP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SaveSelectedPlanetInfo();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}