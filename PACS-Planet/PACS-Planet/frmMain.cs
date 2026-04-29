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

namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void AddLog(string message)
        {
            rtbLogs.AppendText($"[{DateTime.Now:HH:mm:ss}] [INFO ] {message}{Environment.NewLine}");
            rtbLogs.SelectionStart = rtbLogs.Text.Length;
            rtbLogs.ScrollToCaret();
        }

        private void btnSecuritySetup_Click(object sender, EventArgs e)
        {
            AddLog("asd");
        }
    }
}
