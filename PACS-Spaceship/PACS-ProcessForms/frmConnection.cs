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
        public string SelectedTargetIP { get; private set; }

        public frmConnection()
        {
            InitializeComponent();
            InitializeRadar();
        }

        private void InitializeRadar()
        {
            CargarPlanetas();
            btnProceed.Enabled = false;
            txtShipID.Text = ConnectionInfo.ShipID;
            txtDeliveryID.Text = ConnectionInfo.DeliveryID;

            LogToConsole("RADAR SYSTEM INITIALIZED. AWAITING TARGET SELECTION.");
        }

        private void CargarPlanetas()
        {
            try
            {
                DB_CRUD db = new DB_CRUD();
                string consulta = "SELECT idPlanet, CodePlanet, IPPlanet, PortPlanet, PortPlanet1 FROM Planets";
                DataTable dtPlanetas = db.PortarDataTable(consulta);

                if (dtPlanetas.Rows.Count > 0)
                {
                    cmbTargetIP.DataSource = dtPlanetas;
                    cmbTargetIP.DisplayMember = "CodePlanet";
                    cmbTargetIP.ValueMember = "IPPlanet";
                }
            }
            catch (Exception ex)
            {
                LogToConsole($"DB Connection Error: {ex.Message}");
            }
        }

        private void cmbTargetIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTargetIP.SelectedItem is DataRowView filaSeleccionada)
            {
                lblPlanetIPValue.Text = filaSeleccionada["IPPlanet"].ToString();
                lblDataPortValue.Text = filaSeleccionada["PortPlanet"].ToString();
                lblFilePortValue.Text = filaSeleccionada["PortPlanet1"].ToString();

                btnProceed.Enabled = false;
                UpdateStatus("● STANDBY / AWAITING PING", Color.FromArgb(100, 100, 100));
            }
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            string ipAddress = lblPlanetIPValue.Text.Trim();

            if (string.IsNullOrWhiteSpace(ipAddress) || ipAddress == "0.0.0.0" || ipAddress == "--")
            {
                LogToConsole("ERROR: TARGET IP CANNOT BE EMPTY.");
                return;
            }

            btnPing.Enabled = false;
            btnProceed.Enabled = false;
            UpdateStatus("● PINGING TARGET...", Color.FromArgb(242, 214, 75));
            LogToConsole($"Sending ICMP Echo Request to {ipAddress}...");

            try
            {
                using (Ping pingSender = new Ping())
                {
                    PingReply reply = await pingSender.SendPingAsync(ipAddress, 3000);

                    if (reply.Status == IPStatus.Success)
                    {
                        UpdateStatus("● UPLINK ESTABLISHED", Color.FromArgb(0, 255, 100));
                        LogToConsole($"Reply from {reply.Address}: time={reply.RoundtripTime}ms");
                        LogToConsole("TARGET ACQUIRED. COMMLINK READY.");

                        SelectedTargetIP = ipAddress;

                        if (cmbTargetIP.SelectedItem is DataRowView row)
                        {
                            ConnectionInfo.PlanetDataPort = Convert.ToInt32(row["PortPlanet"]);
                            ConnectionInfo.PlanetFilePort = Convert.ToInt32(row["PortPlanet1"]);
                        }

                        btnProceed.Enabled = true;
                    }
                    else
                    {
                        UpdateStatus("● TARGET UNREACHABLE", Color.FromArgb(255, 45, 85));
                        LogToConsole($"Ping failed: {reply.Status}");
                    }
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

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShipID.Text) || string.IsNullOrWhiteSpace(txtDeliveryID.Text))
            {
                MessageBox.Show("Please enter valid Ship ID and Delivery ID to proceed.", "Authorization Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConnectionInfo.TargetPlanetIP = SelectedTargetIP;
            ConnectionInfo.ShipID = txtShipID.Text.Trim();
            ConnectionInfo.DeliveryID = txtDeliveryID.Text.Trim();

            LogToConsole("CREDENTIALS SAVED. INITIATING PROTOCOL TRANSFER...");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region Utilidades Visuales y Log

        private void UpdateStatus(string message, Color color)
        {
            lblStatusValue.Text = message;
            lblStatusValue.ForeColor = color;
        }

        private void LogToConsole(string message)
        {
            string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string logLine = $"[{timeStamp}] {message}";

            if (pacsConsole2 != null)
            {
                pacsConsole2.AddLog(LogLevel.Info, logLine); 
            }
        }

        #endregion
    }
}