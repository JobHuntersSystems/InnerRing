using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inner_DB_Access;

namespace PACS_Center
{
    public partial class frmInnerEncryption : Form
    {
        public frmInnerEncryption(int idPlanet)
        {
            _idPlanet = idPlanet;
            InitializeComponent();            
        }

        private Dictionary<char, string> data;
        private string validationCode;
        Random rng = new Random();
        private int _idPlanet;
        int pass;

        //----------------Genera el codigo de 12 caracteres y lo guarda en la bbdd ------------------------------\\
        private string RandomCode()
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            byte[] data = new byte[12];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(12);
            
            foreach (byte b in data)
            {
                int num = b % (chars.Length);
                result.Append(chars[num]);
            }
            return result.ToString();
        }

        //----------------Genera el diccionario de cifrado letra ------------------------------\\
        private Dictionary<char, string> RandomValue()
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Dictionary<char, string> keyValuePairs = new Dictionary<char, string>();
            HashSet<string> used = new HashSet<string>();

            foreach (var let in letters)
            {
                string value;
                do
                {
                    value = RandomNumber();
                } while (used.Contains(value));
                used.Add(value);

                keyValuePairs.Add(let, value);
            }
            return keyValuePairs;
        }
        private string RandomNumber()
        {
            int num = rng.Next(0, 1000);
            return num.ToString().PadLeft(3, '0');
        }
        
        //----------------Guardar en la base de datos los datos--------------------------------\\
        private void SaveCode()
        {
            try
            {
                DB_CRUD db = new DB_CRUD();
                string id = $"SELECT idInnerEncryption FROM InnerEncryption WHERE idPlanet = {_idPlanet}";
                DataTable dt = db.PortarDataTable(id);

                if(dt.Rows.Count == 0)
                {
                    timerMsj.Stop();
                    btnCode.Enabled = true;
                    lstMsj.Items.Add("Error!! The encryption record for this planet was not found in the database.");
                    return;
                }
                int idInner = (int)dt.Rows[0]["idInnerEncryption"];

                string queryCode = $"Update InnerEncryption SET ValidationCode = '{validationCode}' WHERE idPlanet = {_idPlanet}";
                db.Executa(queryCode);


                string queryDelete = $"DELETE FROM InnerEncryptionData WHERE idInnerEncryption = {idInner}";
                db.Executa(queryDelete);

                foreach (KeyValuePair<char, string> item in data)
                {
                    string queryInsert = $"INSERT INTO InnerEncryptionData (idInnerEncryption, Word, Numbers) " +
                                         $"VALUES ({idInner}, '{item.Key}', '{item.Value}')";

                    db.Executa(queryInsert);
                }
            }
            catch
            {
                timerMsj.Stop();
                btnCode.Enabled = true;
                lstMsj.Items.Add("Error uploading to database!");
            }
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            btnCode.Enabled = false;
            
            pass = 0;
            lstMsj.Items.Clear();

            timerMsj.Start();     
        }

        //------------------Mensajes en pantalla y flujo del codigo-----------------------------\\

        private void timerMsj_Tick(object sender, EventArgs e)
        {
            switch (pass)
            {
                case 0:
                    lstMsj.Items.Add("Generating encoding...");
                    validationCode = RandomCode();
                    data = RandomValue();
                    break;
                case 1:
                    lstMsj.Items.Add("Validating encoding...");
                    break;
                case 2:
                    lstMsj.Items.Add("Encoding validated.");
                    timerMsj.Interval = 1000;
                    break;
                case 3:
                    lstMsj.Items.Add("Uploading encoding to the system...");
                    SaveCode();
                    timerMsj.Interval = 2000;
                    break;
                case 4:
                    lstMsj.Items.Add("Upload completed.");

                    timerMsj.Stop();
                    btnCode.Enabled = true;
                    break;
            }
            pass++;
        }
    }
}
