using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PACS_UI;
using PACS_Common;
using TcpManager;

namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            PACS_Common.Planet.idPlanet = 7;
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
        private void openForm(Form frm)
        {
            frm.TopLevel = false;

            frm.FormBorderStyle = FormBorderStyle.None;

            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
        private void OnMessageReceived(object sender, EventArgs e)
        {
            var tpc_manager = (frmTcpManager.ManagerEventArgs)e;
            genericInvokeAction(pcsConsoleMain, () =>
            {
                pcsConsoleMain.AddLog(
                    tpc_manager.Level,
                    tpc_manager.Message
                );
            });
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
                    break;
                }
            }
            if (!formOpened)
            {
                formManager = new frmTcpManager();
                formManager.SendMessage += new EventHandler(OnMessageReceived);

                openForm(formManager);
            }
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
