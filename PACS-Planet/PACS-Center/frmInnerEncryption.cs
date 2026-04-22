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

namespace PACS_Center
{
    public partial class frmInnerEncryption : Form
    {
        public frmInnerEncryption(int idPlanet)
        {
            _idPlanet = idPlanet;
            InitializeComponent();
            validationCode = RandomCode();
            data = RandomValue();
        }
        private Dictionary<char, string> data;
        private string validationCode;
        Random rng = new Random();
        private int _idPlanet;

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

        //----------------Genera el diccionario de cifrado Letra ------------------------------\\
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
            //hacer que el codigo de 12 sea un update y para las letras un delete y insert
        }
        
    }
}
