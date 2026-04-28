using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Inner_DB_Access
{
    public class DB_CRUD
    {
        public DB_CRUD()
        {
            Connectar();
            EncryptConnection();
        }

        #region Variables Globales

        //Connexión
        ConnectionStringSettings conf;
        private string cnx;
        private SqlConnection cnn;
        private SqlDataAdapter adapter;

        #endregion

        /// Método que permite encriptar la conexión string que se encuentra dentro de app.config.
        private void EncryptConnection()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration("JobHuntersSystem.exe");
            ConnectionStringsSection section = configuration.GetSection("connectionStrings") as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }

            configuration.Save();

        }
        /// Método que realiza la conexión a la base de datos
        private void Connectar()
        {
            conf = ConfigurationManager.ConnectionStrings["SecureCoreG2Connection"];
            if (conf != null)
            {
                cnx = conf.ConnectionString;
                cnn = new SqlConnection(cnx);
            }
        }





        /// Ejecuta una consulta SQL y devuelve los resultados. Se le manda la query que se desea ejecutar.</param>
        /// Un DataSet con los resultados de la consulta.

        public DataSet PortarPerConsulta(string consultaSql)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet;
        }

        /// Ejecuta una consulta SQL y llena un DataSet con los resultados,
        /// asignándolos a una tabla con el nombre indicado.
        public DataSet PortarPerConsulta(string consultaSql, string nomTabla)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, nomTabla);
            cnn.Close();

            return dataSet;
        }

        /// Actualiza los cambios realizados en un DataSet hacia la base de datos,
        /// utilizando la consulta SQL original como referencia.       
        public void Actualitzar(string consultaSqlOG, DataSet dataSet)
        {
            adapter = new SqlDataAdapter(consultaSqlOG, cnn);
            SqlCommandBuilder commandBuilder;
            commandBuilder = new SqlCommandBuilder(adapter);

            cnn.Open();
            if (dataSet.HasChanges())
            {
                adapter.Update(dataSet.Tables[0]);
            }
            cnn.Close();
        }

        /// Ejecuta una consulta SQL y devuelve los resultados en un DataTable.
        public DataTable PortarDataTable(string consultaSql)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet.Tables[0];
        }

        /// Ejecuta una consulta SQL y añade los resultados como una nueva tabla
        /// dentro de un DataSet existente.
        public DataSet AfegirDataTable(string consultaSql, DataSet dataSet)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataTable newTable = new DataTable();
            adapter.Fill(newTable);
            cnn.Close();

            dataSet.Tables.Add(newTable);

            return dataSet;

        }

        /// Ejecuta una instrucción SQL que no devuelve resultados,
        /// como INSERT, UPDATE o DELETE.
        public void Executa(string querySQL)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(querySQL, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();
        }

        /// Genera y ejecuta una consulta SQL de búsqueda sobre una tabla,
        /// utilizando pares clave-valor como filtros con la cláusula LIKE.
        public DataSet GeneraConsultaCerca(string nomTaula, Dictionary<string, string> keyValuePairs)
        {
            SqlCommand cmd = cnn.CreateCommand();
            DataSet data = new DataSet();

            cmd.CommandType = CommandType.Text;
            string query = "SELECT * FROM " + nomTaula +
                                    " WHERE";

            foreach (var item in keyValuePairs)
            {
                string paramValue = $"%{item.Value}%";
                string paramName = "@" + item.Key;
                query += $" {item.Key} LIKE {paramName} AND";
                cmd.Parameters.Add(new SqlParameter(paramName, paramValue));
            }
            query = query.Substring(0, query.Length - 3);


            cmd.CommandText = query;
            cnn.Open();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();

            return data;
        }

    }
}
