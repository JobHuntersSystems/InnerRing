using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TcpManager;
using System.Collections.Generic;
using PACS_Center;
using PACS_ZipGenerator;
using PACS_ChecksumCalculator;
using PACS_Common;
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
        private void OnZipIsGenerated(object sender, EventArgs e)
        {
            var zip = (FrmPacsZipGenerator.ZipSentToMainEventArgs)e;
            if(formManager != null)
            {
                ((Form)sender).Close();
                obtnGenerateZip.Visible = false;
                formManager.BringToFront();
                formManager.WindowState = FormWindowState.Maximized;
               
                formManager.sendZip(Spaceship.ip,Spaceship.filePort, zip.Path);
            }
        }
        private void OnCheckSumIsDone(object sender, EventArgs e)
        {

            var check = (FrmPacsChecksumCalculator.ChecksumCalculatedToMainEventArgs)e;

            if (formManager != null)
            {
                formManager.BringToFront();
                formManager.WindowState = FormWindowState.Maximized;

                if (check.GlobalChecksum)
                {
                    ((Form)sender).Close();
                    obtnCheckSum.Visible = false;
                    pcsStageIndicator.CompleteStage(3);

                }
                else
                {
                    pcsStageIndicator.FailStage(3);
                    obtnCheckSum.Visible = false;
                    obtnGenerateZip.Visible = false;
                }
                formManager.sendFinalValidation(Spaceship.ip, Spaceship.dataPort, check.GlobalChecksum);
                
            }
        }
        private void OnNotificationRecived(object sender, EventArgs e)
        {
            var tcp = (frmTcpManager.NotificationSentEventArgs)e;
            int stage = tcp.Stage;
            bool able = tcp.Able;
            switch (stage)
            {
                case 1:
                    if (able)
                    {
                        pcsStageIndicator.CompleteStage(stage);
                    }
                    else
                    {
                        string message = "VR" + Spaceship.CurrentStage + Spaceship.code + "AD";
                        pcsStageIndicator.FailStage(stage);
                        formManager.finishingFaildProtocol(message);
                        obtnCheckSum.Visible = false;
                        obtnGenerateZip.Visible = false;
                    }
                    break;

                case 2:
                    if (able)
                    {
                        pcsStageIndicator.CompleteStage(stage);
                        genericInvokeAction(obtnGenerateZip, () => obtnGenerateZip.Visible = true);
                    }
                    else
                    {
                        string message = "VR" + Spaceship.CurrentStage + Spaceship.code + "AD";
                        pcsStageIndicator.FailStage(stage);
                        formManager.finishingFaildProtocol(message);
                        obtnCheckSum.Visible = false;
                        obtnGenerateZip.Visible = false;
                    }
                    break;

                case 3:
                    if (able)
                    {
                        genericInvokeAction(obtnCheckSum, () => obtnCheckSum.Visible = true);
                    }
                    break;

                case 200:
                    pcsStageIndicator.ResetStages();
                    break;

                case -1:
                    pcsStageIndicator.ResetStages();
                    obtnCheckSum.Visible = false;
                    obtnGenerateZip.Visible = false;
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
                formManager.ZipSentToMain += new EventHandler(OnZipIsGenerated);
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
                formManager.ChecksumCalculatedToMain += new EventHandler(OnCheckSumIsDone);
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