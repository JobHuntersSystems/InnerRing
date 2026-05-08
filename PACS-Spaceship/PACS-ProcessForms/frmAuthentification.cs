using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACS_ProcessForms
{
    public partial class frmAuthentification : Form
    {
        public frmAuthentification()
        {
            InitializeComponent();
        }

        private void btnPhase1_Click(object sender, EventArgs e)
        {
            btnPhase1.Enabled = false;
            btnPhase2.Enabled = true;
        }

        private void btnPhase2_Click(object sender, EventArgs e)
        {
            btnPhase2.Enabled = false;
            btnPhase3.Enabled = true;
        }

        private void btnPhase3_Click(object sender, EventArgs e)
        {
            btnPhase3.Enabled = false;
            btnPhase4.Enabled = true;
        }
    }
}
