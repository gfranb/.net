using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App.SQL
{
    internal class SQLConnector
    {
        SqlConnection connection = new SqlConnection();

        static string servidor = "localhost";
        static string username = "NewSA";
        static string password = "root";
        static string bd = "netAssistants";
        static string port = "1433";

        string cadenaConexion = "Data Source=" + servidor + "," + port + ";" + "user id=" + username + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";

        public SqlConnection Connection()
        {
            try{
                connection.ConnectionString = cadenaConexion;
                connection.Open();
                MessageBox.Show("Conexion a la base de datos exitosa");
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error al conectar a la base de datos"+e.ToString());
            }
            return connection;
        }
    }
}
