using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PACS_UI;
using PACS_Common;
using TcpManager;
using System.Collections.Generic;
using PACS_Center;

namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        private Thread serverThread;

        public frmMain()
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
        private Dictionary<int, string> protocol_stages = new Dictionary<int, string>()
        {
            {1, "☑️ Stage 1: Delivery schedule"},
            {2, " ⬜ Stage 2: Validation Code"},
            {3, " ⬜ Stage 3: Check Sum"},
        };

        private void openForm(Form frm)
        {
            frm.TopLevel = false;

            frm.FormBorderStyle = FormBorderStyle.None;

            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
        private void OnNewClientDetected(object sender, EventArgs e)
        {

            var tpc = (frmTcpManager.NotificationSentEventArgs)e;
            string result = $"=== {tpc.Message} ===\n";

            foreach (var stage in protocol_stages)
            {
                result += stage.Value + "\n";
            }

            genericInvokeAction(pcsConsoleMain, () =>
                pcsConsoleMain.AddData(
                    result
            ));
        }
        private void OnNotificationReceived(object sender, EventArgs e)
        {
            var tpc_manager = (frmTcpManager.NotificationSentEventArgs)e;
            genericInvokeAction(pcsConsoleMain, () =>
                pcsConsoleMain.AddLog(
                    tpc_manager.Level,
                    tpc_manager.Message
            ));
        }
        private void obtnTCP_Click(object sender, EventArgs e)
        {
            bool formOpened = false;
            frmTcpManager formManager;
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmTcpManager)
                {
                    formOpened = true;
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (!formOpened)
            {
                formManager = new frmTcpManager();
                formManager.NotificationSent += new EventHandler(OnNewClientDetected);

                openForm(formManager);
            }
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void obtnValidationCode_Click(object sender, EventArgs e)
        {
            bool formOpened = false;
            frmInnerEncryption formManager;
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmInnerEncryption)
                {
                    formOpened = true;
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (!formOpened)
            {
                formManager = new frmInnerEncryption();
                openForm(formManager);
            }
        }

        private void obtnRsa_Click(object sender, EventArgs e)
        {
            bool formOpened = false;
            frmKeyManager formManager;
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmKeyManager)
                {
                    formOpened = true;
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (!formOpened)
            {
                formManager = new frmKeyManager();
                openForm(formManager);
            }
        }

        private void pctConfiguration_Click(object sender, EventArgs e)
        {
            frmPlanetConfig frm = new frmPlanetConfig();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}