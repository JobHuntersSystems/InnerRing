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
            InitializeComponent();
        }

        private void btnKeyGenerator_Click(object sender, EventArgs e)
        {
            string keyName = tbx_container.Text;
            if (string.IsNullOrEmpty(keyName))
            {
                MessageBox.Show("Rellene el nombre de la key para poder seguir con el proceso");
                return;
            }

            CspParameters cspp = new CspParameters { KeyContainerName = keyName};

            using(RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp))
            {
                rsa.PersistKeyInCsp = true;
                string publicKey = rsa.ToXmlString(false);

                string filePath = $"{keyName}_PublicKey.xml";
                File.WriteAllText(filePath, publicKey);
            }
        }
    }
}
