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

        /// <summary>
        /// Método que permite encriptar la conexión string que se encuentra dentro de app.config.
        /// </summary>
        /// <remarks>Este método no se puede llamar y ejecuta cuadno se crea el objeto.</remarks>
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
        /// <summary>
        /// Método que realiza la conexión a la base de datos
        /// </summary>
        /// <remarks>Este método no se llamará y </remarks>
        private void Connectar()
        {
            conf = ConfigurationManager.ConnectionStrings["SecureCoreG2Connection"];
            if (conf != null)
            {
                cnx = conf.ConnectionString;
                cnn = new SqlConnection(cnx);
            }
        }

        /// <summary>
        /// Devuelve todos los registros de la tabla indicada.
        /// </summary>
        /// <param name="NomTaula">Nombre de la tabla a consultar.</param>
        /// <returns>Un DataSet con los registros de la tabla.</returns>
        /// <example>
        /// <code>
        /// string nomTaula;
        /// DataSet clientes = PortarTaula(nomTaula);
        /// foreach (DataRow fila in clientes.Tables[0].Rows)
        /// {
        ///     Console.WriteLine(fila["Nombre"]);
        /// }
        /// </code>
        /// </example>
        public DataSet PortarTaula(string NomTaula)
        {
            string query = "select * from " + NomTaula;
            adapter = new SqlDataAdapter(query, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados.
        /// </summary>
        /// <param name="consultaSql">Consulta SQL que se desea ejecutar.</param>
        /// <returns>Un DataSet con los resultados de la consulta.</returns>
        /// <example>
        /// <code>
        /// string sql;
        /// DataSet clientesActivos = PortarPerConsulta(sql);
        /// foreach (DataRow fila in clientesActivos.Tables[0].Rows)
        /// {
        ///     Console.WriteLine(fila["Nombre"]);
        /// }
        /// </code>
        /// </example>
        public DataSet PortarPerConsulta(string consultaSql)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y llena un DataSet con los resultados,
        /// asignándolos a una tabla con el nombre indicado.
        /// </summary>
        /// <param name="consultaSql">Consulta SQL que se desea ejecutar.</param>
        /// <param name="nomTabla">Nombre que se asignará a la tabla dentro del DataSet.</param>
        /// <returns>Un DataSet con los resultados de la consulta.</returns>
        /// <example>
        /// <code>
        /// string consultaSql = "SELECT * FROM " + nomTaula;
        /// DataSet datos = PortarPerConsulta(consultaSql, nomTaula);
        /// foreach (DataRow fila in datos.Tables[nomTaula].Rows)
        /// {
        ///     Console.WriteLine(fila["ColumnaEjemplo"]);
        /// }
        /// </code>
        /// </example>
        public DataSet PortarPerConsulta(string consultaSql, string nomTabla)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, nomTabla);
            cnn.Close();

            return dataSet;
        }

        /// <summary>
        /// Actualiza los cambios realizados en un DataSet hacia la base de datos,
        /// utilizando la consulta SQL original como referencia.
        /// </summary>
        /// <param name="consultaSqlOG">Consulta SQL original que define la tabla a actualizar.</param>
        /// <param name="dataSet">DataSet que contiene los cambios a aplicar.</param>
        /// <example>
        /// <code>
        /// string consultaSqlOG = "SELECT * FROM " + nomTaula;
        /// DataSet dataSet = PortarPerConsulta(consultaSqlOG, nomTaula);
        ///
        /// dataSet.Tables[nomTaula].Rows[0]["ColumnaEjemplo"] = "NuevoValor";
        ///
        /// Actualitzar(consultaSqlOG, dataSet);
        /// </code>
        /// </example>
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
        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados en un DataTable.
        /// </summary>
        /// <param name="consultaSql">Consulta SQL que se desea ejecutar.</param>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>
        /// <example>
        /// <code>
        /// string consultaSql = "SELECT * FROM " + nomTaula;
        /// DataTable datos = PortarDataTable(consultaSql);
        ///
        /// foreach (DataRow fila in datos.Rows)
        /// {
        ///     Console.WriteLine(fila["ColumnaEjemplo"]);
        /// }
        /// </code>
        /// </example>
        public DataTable PortarDataTable(string consultaSql)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet.Tables[0];
        }

        /// <summary>
        /// Ejecuta una consulta SQL y añade los resultados como una nueva tabla
        /// dentro de un DataSet existente.
        /// </summary>
        /// <param name="consultaSql">Consulta SQL que se desea ejecutar.</param>
        /// <param name="dataSet">DataSet al que se añadirá la nueva tabla.</param>
        /// <returns>El DataSet original con la nueva tabla añadida.</returns>
        /// <example>
        /// <code>
        /// string consultaSql = "SELECT * FROM " + nomTaula;
        /// DataSet dataSet = new DataSet();
        /// dataSet = AfegirDataTable(consultaSql, dataSet);
        /// DataTable nuevaTabla = dataSet.Tables[dataSet.Tables.Count - 1];
        /// foreach (DataRow fila in nuevaTabla.Rows)
        /// {
        ///     Console.WriteLine(fila["ColumnaEjemplo"]);
        /// }
        /// </code>
        /// </example>
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
        /// <summary>
        /// Ejecuta una instrucción SQL que no devuelve resultados,
        /// como INSERT, UPDATE o DELETE.
        /// </summary>
        /// <param name="querySQL">Consulta SQL que se desea ejecutar.</param>
        /// <example>
        /// <code>
        /// string querySQL = "UPDATE " + nomTaula + " SET ColumnaEjemplo = 'NuevoValor' WHERE Id = 1";
        /// Executa(querySQL);
        /// </code>
        /// </example>
        public void Executa(string querySQL)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(querySQL, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();
        }

        /// <summary>
        /// Genera y ejecuta una consulta SQL de búsqueda sobre una tabla,
        /// utilizando pares clave-valor como filtros con la cláusula LIKE.
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla sobre la que se realizará la búsqueda.</param>
        /// <param name="keyValuePairs">
        /// Diccionario con los filtros de búsqueda, donde la clave es el nombre de la columna
        /// y el valor es el texto a buscar.
        /// </param>
        /// <returns>Un DataSet con los resultados de la consulta.</returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var keyValuePairs = new Dictionary string, string
        /// {
        ///     { "Nombre", "Juan" },
        ///     { "Ciudad", "Barcelona" }
        /// };
        ///
        /// DataSet resultados = GeneraConsultaCerca(nomTaula, keyValuePairs);
        ///
        /// foreach (DataRow fila in resultados.Tables[0].Rows)
        /// {
        ///     Console.WriteLine(fila["Nombre"] + " - " + fila["Ciudad"]);
        /// }
        /// </code>
        /// </example>
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
