using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using Inner_DB_Access;

namespace PACS_Center
{
    public class InnerEncryption
    {
        Random rng = new Random();
        DB_CRUD db = new DB_CRUD();

        public void SaveCode(int _idPlanet, string validationCode, Dictionary<char, string> data)
        {
            string id = $"SELECT idInnerEncryption FROM InnerEncryption WHERE idPlanet = {_idPlanet}";
            DataTable dt = db.PortarDataTable(id);

            if (dt.Rows.Count == 0)
            {
                string queryInsert = $"INSERT INTO InnerEncryption (idPlanet, ValidationCode) " +
                                        $"VALUES ({_idPlanet}, '{validationCode}')";
                db.Executa(queryInsert);
                dt = db.PortarDataTable(id);
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

        //----------------Genera el codigo de 12 caracteres y lo guarda en la bbdd ------------------------------\\
        public string RandomCode()
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

        private string RandomNumber()
        {
            int num = rng.Next(0, 1000);
            return num.ToString().PadLeft(3, '0');
        }

        //----------------Genera el diccionario de cifrado letra ------------------------------\\
        public Dictionary<char, string> RandomValue()
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
    }
}
