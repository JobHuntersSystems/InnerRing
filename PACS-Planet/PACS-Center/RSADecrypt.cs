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
    public class clsDecrypt
    {
        DB_CRUD db = new DB_CRUD();
        private string GetContainerName(int idPlanet)
        {
            string query = $"SELECT CodePlanet FROM Planets WHERE idPlanet = {idPlanet}";
            DataTable dt = db.PortarDataTable(query);
            if (dt.Rows.Count == 0)
            {
                throw new Exception($"The planet with idPlanet={idPlanet} was not found.");
            }
            return dt.Rows[0]["CodePlanet"].ToString();
        }

        public string DecryptMessage(int idPlanet, string msj)
        {
            string containerName = GetContainerName(idPlanet);
            byte[] encryptedBytes = Convert.FromBase64String(msj);

            CspParameters csp = new CspParameters { KeyContainerName = containerName };
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                byte[] decryptData = RSA.Decrypt(encryptedBytes, false);

                UnicodeEncoding ByCo = new UnicodeEncoding();
                return ByCo.GetString(decryptData);
            }
        }
    }
}