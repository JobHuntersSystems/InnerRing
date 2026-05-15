using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PACS_UI;
using TcpManager;
using System.Collections.Generic;
using PACS_Center;
using PACS_ZipGenerator;
using PACS_ChecksumCalculator;

namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        frmTcpManager formManager;
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
        private void openForm(Form frm)
        {
            frm.TopLevel = false;

            frm.FormBorderStyle = FormBorderStyle.None;

            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
        #endregion
        private Dictionary<int, string> protocol_stages = new Dictionary<int, string>()
        {
            {1, "☑️ Stage 1: Delivery schedule"},
            {2, " ⬜ Stage 2: Validation Code"},
            {3, " ⬜ Stage 3: Check Sum"},
        };

        private void showNewProtocolStage()
        {

        }
        private void OnZipIsGenerated(object sender, EventArgs e)
        {
            if(formManager != null)
            {
                
            }
        }
        private void OnCheckSumIsDone(object sender, EventArgs e)
        {
            if (formManager != null)
            {

            }
        }
        private void OnNotificationRecived(object sender, EventArgs e)
        {
            var tcp = (frmTcpManager.NotificationSentEventArgs)e;
            int stage = tcp.Stage;
            bool able = tcp.Able;
            switch (stage)
            {
                case 0:
                    showNewProtocolStage();
                    break;
                case 1:
                    break;
                case 2:
                    if (able)
                    {
                        genericInvokeAction(obtnGenerateZip, () => obtnGenerateZip.Visible = true);
                    }
                    break;
            }
        }
        private void obtnTCP_Click(object sender, EventArgs e)
        {
            bool formOpened = false;
          
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
                formManager.NotificationSent += new EventHandler(OnNotificationRecived);

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
        private void obtnGenerateZip_Click(object sender, EventArgs e)
        {
            bool formOpened = false;
            FrmPacsZipGenerator formManager;
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmPacsZipGenerator)
                {
                    formOpened = true;
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (!formOpened)
            {
                formManager = new FrmPacsZipGenerator();
                openForm(formManager);
            }
        }

        private void obtnCheckSum_Click(object sender, EventArgs e)
        {
            bool formOpened = false;
            FrmPacsChecksumCalculator formManager;
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmPacsChecksumCalculator)
                {
                    formOpened = true;
                    form.BringToFront();
                    form.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (!formOpened)
            {
                formManager = new FrmPacsChecksumCalculator();
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

    }
}