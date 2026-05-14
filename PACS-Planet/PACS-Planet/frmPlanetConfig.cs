
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PACS_Common;

namespace PACS_Planet
{
    public partial class frmPlanetConfig : Form
    {
        string RootPlanetPath;
        public frmPlanetConfig()
        {
            InitializeComponent();
            RootPlanetPath = AppDomain.CurrentDomain.BaseDirectory + @"Resources\Planets";
        }
 
        private void frmPlanetConfig_Load(object sender, EventArgs e)
        {
            LoadPlanetData();
        }

        private void LoadPlanetData()
        {
            txtIdPlanet.Text = Planet.idPlanet.ToString();
            txtCodePlanet.Text = Planet.CodePlanet;
            txtDescPlanet.Text = Planet.DescPlanet;

            txtPlanetPicture.Text = Planet.PlanetPicture;

            txtIPPlanet.Text = Planet.IPPlanet;
            txtPortPlanet.Text = Planet.PortPlanet;
            txtPortPlanet1.Text = Planet.PortPlanet1;

            LoadPlanetImage();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            int planetId;

            if (!int.TryParse(txtIdPlanet.Text.Trim(), out planetId))
            {
                MessageBox.Show(
                    "El ID del planeta debe ser numérico.",
                    "PACS Planet Configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Planet.idPlanet = planetId;
            Planet.CodePlanet = txtCodePlanet.Text.Trim();
            Planet.DescPlanet = txtDescPlanet.Text.Trim();
            Planet.PlanetPicture = txtPlanetPicture.Text.Trim();
            Planet.IPPlanet = txtIPPlanet.Text.Trim();
            Planet.PortPlanet = txtPortPlanet.Text.Trim();
            Planet.PortPlanet1 = txtPortPlanet1.Text.Trim();

            LoadPlanetImage();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogPlanetImage.ShowDialog() == DialogResult.OK)
            {
                txtPlanetPicture.Text = openFileDialogPlanetImage.FileName;
                LoadPlanetImage();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPlanetImage()
        {
            string path = Path.Combine(RootPlanetPath, Planet.PlanetPicture);

            if (File.Exists(path))
            {
                pctPlanet.ImageLocation = path;
            }
            else
            {
                pctPlanet.Image = null;
            }
        }
    }
}