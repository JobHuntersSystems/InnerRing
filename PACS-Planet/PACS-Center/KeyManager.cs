using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inner_DB_Access;
using System.Data;
using System.Security.Cryptography;

namespace PACS_Center
{
    public class KeyManager
    {
        private DB_CRUD db = new DB_CRUD();
        public string SearchCode(int idPlanet)
        {
            string code = "";
            
            string queryCode = $"SELECT CodePlanet FROM Planets WHERE idPlanet = {idPlanet}";
            DataTable dt = db.PortarDataTable(queryCode);

            if (dt.Rows.Count > 0)
            {
                code = dt.Rows[0]["CodePlanet"].ToString();
            }
            return code;
        }

        //----------------Guardar en la base de datos los datos--------------------------------\\
        public void SaveDataBase(string key, int idPlanet)
        {
            string queryCheck = $"SELECT idPlanet FROM PlanetKeys WHERE idPlanet = {idPlanet}";
            DataTable dt = db.PortarDataTable(queryCheck);

            string query;
            if (dt.Rows.Count > 0)
            {
                query = $"UPDATE PlanetKeys SET XMLKey = '{key}' WHERE idPlanet = {idPlanet}";
            }
            else
            {
                query = $"INSERT INTO PlanetKeys (idPlanet, XMLKey) VALUES ({idPlanet}, '{key}')";
            }
            db.Executa(query);
        }

        //-------------------------Generar keys----------------------\\
        public string GenerateRsaKey(string containerName)
        {
            CspParameters cspp = new CspParameters { KeyContainerName = containerName };

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp))
            {
                rsa.PersistKeyInCsp = true;
                return rsa.ToXmlString(false);
            }
        }
    }
}
