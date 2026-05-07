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
using PACS_Center;

namespace PACS_Planet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            PACS_Common.Planet.idPlanet = 7;
        }

        private void btnSecuritySetup_Click(object sender, EventArgs e)
        {
        
        }
    }
}
