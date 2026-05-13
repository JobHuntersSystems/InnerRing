using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Inner_DB_Access;

namespace PACS_Center
{
    public partial class frmKeyManager : Form
    {
        public frmKeyManager()
        {
            _idPlanet = PACS_Common.Planet.idPlanet;
            InitializeComponent();
        }
        private int _idPlanet;

        private void btnKeyGenerator_Click(object sender, EventArgs e)
        {            
            DialogResult validation = MessageBox.Show("Press confirm to generate the keys","Are you sure?", MessageBoxButtons.OKCancel) ;
            if (validation == DialogResult.OK)
            {
                try
                {
                    KeyManager cls = new KeyManager();
                    string keyName = cls.SearchCode(_idPlanet);

                    if (string.IsNullOrEmpty(keyName))
                    {
                        lblMessage.Text = "Error: Planet code not found.";
                        return;
                    }
                    string publicKey = cls.GenerateRsaKey(keyName);
                    cls.SaveDataBase(publicKey, _idPlanet);

                    lblMessage.Text = "The key pair has been generated and saved successfully.";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = $"An error occurred while generating or saving the key:\n\n{ ex.Message}";
                }                
            }            
        }        
    }
}
