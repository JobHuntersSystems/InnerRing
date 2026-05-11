using System;
using System.Windows.Forms;
using PACS_Common;

namespace PACS_Spaceship
{
    public partial class FrmMain : Form
    {
        DateTime horaLocal = DateTime.Now;
        public FrmMain()
        {
            InitializeComponent();
            lblClockTag.Text = "SECTOR TIME: "+ horaLocal.ToString("HH:mm:ss")  + " // UTC+00";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}