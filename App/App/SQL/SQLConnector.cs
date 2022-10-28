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
        public void CreateTable()
        {

            string createTableStatementMercancia = "CREATE TABLE Mercancia(id_mercancia varchar(10) PRIMARY KEY, nombre VARCHAR(10), volumenProducto FLOAT)";
            string createTableStatementVehiculo = ""; //Llenar con query SQL
            string createTableStatementConductor = ""; //Llenar con query SQL
            string createTableStatementRuta = ""; //Llenar con query SQL

            try
            {

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd;
                cmd = new SqlCommand(createTableStatementMercancia, connection);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(createTableStatementVehiculo, connection);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(createTableStatementConductor, connection);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(createTableStatementRuta, connection);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Tabla Mercancia creada");

            }
            catch(Exception e)
            {
                //MessageBox.Show(e.Message);
            }

        }

    }

    
}
