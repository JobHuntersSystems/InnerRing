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

        //-------------------------Generar keys----------------------\\
        private void btnKeyGenerator_Click(object sender, EventArgs e)
        {
            string keyName = SearchCode();
            
            DialogResult validation = MessageBox.Show("Press confirm to generate the keys","Are you sure?", MessageBoxButtons.OKCancel) ;
            if (validation == DialogResult.OK)
            {
                try
                {
                    CspParameters cspp = new CspParameters { KeyContainerName = keyName };
                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp))
                    {
                        rsa.PersistKeyInCsp = true;
                        string publicKey = rsa.ToXmlString(false);

                        SaveDataBase(publicKey);
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = $"An error occurred while generating or saving the key:\n\n{ ex.Message}";
                }                
            }            
        }

        //----------------------- Consultas de la Base de datos -------------------------\\

        private string SearchCode()
        {
            string code = "";
            try
            {
                DB_CRUD db = new DB_CRUD();
                string queryCode = $"SELECT CodePlanet FROM Planets WHERE idPlanet = {_idPlanet}";
                DataTable dt = db.PortarDataTable(queryCode);

                if (dt.Rows.Count > 0)
                {
                    code = dt.Rows[0]["CodePlanet"].ToString();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Connection error while searching for the planet code:\n\n{ex.Message}";
            }
            return code;
        }

        private void SaveDataBase(string key)
        {
            try
            {
                DB_CRUD db = new DB_CRUD();

                string queryCheck = $"SELECT idPlanet FROM PlanetKeys WHERE idPlanet = {_idPlanet}";
                DataTable dt = db.PortarDataTable(queryCheck);

                if (dt.Rows.Count > 0)
                {
                    string queryUpdate = $"UPDATE PlanetKeys SET XMLKey = '{key}' WHERE idPlanet = {_idPlanet}";
                    db.Executa(queryUpdate);
                }
                else
                {
                    string queryInsert = $"INSERT INTO PlanetKeys (idPlanet, XMLKey) VALUES ({_idPlanet}, '{key}')";
                    db.Executa(queryInsert);
                }

                lblMessage.Text = "The key pair has already been generated";
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Failed to save the key in the PlanetKeys table:\n\n{ex.Message}";                 
            }
        }
    }
}
