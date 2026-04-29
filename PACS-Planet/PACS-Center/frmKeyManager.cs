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

namespace PACS_Center
{
    public partial class frmKeyManager : Form
    {
        public frmKeyManager()
        {
            //int idPlanet
            InitializeComponent();
        }

        //-------------------------Generar keys----------------------\\
        private void btnKeyGenerator_Click(object sender, EventArgs e)
        {
            string keyName = SearchCode();
            if (string.IsNullOrEmpty(keyName))
            {
                MessageBox.Show("Rellene el nombre de la key para poder seguir con el proceso");
                return;
            }

            
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

                        string filePath = $"{keyName}_PublicKey.xml";
                        File.WriteAllText(filePath, publicKey);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al generar o guardar la clave:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }            
        }

        private string SearchCode()
        {
            string code = "a";
            //metodo/query para hacer busqueda del codigo del planeta y agregarlo en el key container
            return code;
        }

    }
}
