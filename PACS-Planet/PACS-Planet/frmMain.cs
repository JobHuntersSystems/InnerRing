using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PACS_UI;


namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        private Thread serverThread;

        public frmMain()
        {
            InitializeComponent();
        }

    }
}