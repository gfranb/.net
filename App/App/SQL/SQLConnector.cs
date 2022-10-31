using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using WindowsFormsApp1.modelo;

namespace App.SQL
{
    internal class SQLConnector
    {

        public void showValuesGrid(DataGridView dataGridView1)
        {
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                dataGridView1.DataSource = db.Mercancia.ToList();
            }
        }

        public void exportDataXML()
        {
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                try
                {
                    XElement DBtoXML = new XElement("Lista",
                    (from tbl in db.Conductor
                     select new
                     {
                         tbl.id_conductor,
                         tbl.nombre,
                         tbl.apellidos,
                         tbl.domicilio,
                         tbl.permiso,
                         tbl.disponibilidad
                     }).ToList().Select(x => new XElement("Conductor",
                                             new XElement("id_conductor", x.id_conductor),
                                             new XElement("nombre", x.nombre),
                                             new XElement("apellido", x.apellidos),
                                             new XElement("domicilio", x.domicilio),
                                             new XElement("permiso", x.permiso),
                                             new XElement("disponibilidad", x.disponibilidad)
                                             )));
                    FileStream xmlFile = File.OpenWrite(@"conductores.xml");
                    byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                    xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                    xmlFile.Close();
                    MessageBox.Show("El XML se ha generado correctamente");

                }
                catch (Exception error)
                {

                    MessageBox.Show("Error al cargar el XML " + error.Message);

                }

                using (netAssistantsEntities _db = new netAssistantsEntities())
                {
                    try
                    {
                        XElement DBtoXML = new XElement("Lista",
                        (from tbl in _db.Mercancia
                         select new
                         {
                             tbl.id_producto,
                             tbl.nombre,
                             tbl.volumenProducto,

                         }).ToList().Select(x => new XElement("Mercancia",
                                                 new XElement("id_producto", x.id_producto),
                                                 new XElement("nombre", x.nombre),
                                                 new XElement("volumenProducto", x.volumenProducto)
                                                 )));
                        FileStream xmlFile = File.OpenWrite(@"mercancias.xml");
                        byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                        xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                        xmlFile.Close();
                        MessageBox.Show("El XML se ha generado correctamente");

                    }
                    catch (Exception error)
                    {

                        MessageBox.Show("Error al cargar el XML " + error.Message);

                    }

                }

                /*using (netAssistantsDB db = new netAssistantsDB())

                {
                    DataTable dt = new DataTable();
                    dt.TableName = "Conductor";
                    Conductor c = new Conductor();
                    c.GetType().GetProperties().ToList().ForEach(_c =>
                    {
                        _c.GetValue(c, null);
                        dt.Columns.Add(_c.Name, Nullable.GetUnderlyingType(_c.PropertyType) ?? _c.PropertyType);
                    });

                    foreach(var conductor in db.Conductors)
                    {
                        dt.Rows.Add(conductor.id_conductor,conductor.nombre,conductor.apellidos,conductor.domicilio,conductor.permiso,conductor.disponibilidad);
                    }
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    ds.WriteXml(File.OpenWrite(@"conductores.XML"));
                    MessageBox.Show("XML de conductor generado");
                }*/

            }
        }

        public void importDataXML()
        {
            XDocument xDoc = XDocument.Load(@"conductores.xml");

            try
            {

                List<Conductor> conductores = xDoc.Descendants("Conductor").Select
                (conductor =>
                new Conductor
                {
                    id_conductor = Int32.Parse(conductor.Element("id_conductor").Value),
                    nombre = conductor.Element("nombre").Value,
                    apellidos = conductor.Element("apellido").Value,
                    domicilio = conductor.Element("domicilio").Value,
                    permiso = conductor.Element("permiso").Value,
                    disponibilidad = bool.Parse(conductor.Element("disponibilidad").Value)
                }
                ).ToList();

                using (netAssistantsEntities db = new netAssistantsEntities())
                {
                    foreach (var i in conductores)
                    {
                        var v = db.Conductor.Where(a => a.id_conductor.Equals(i.id_conductor)).FirstOrDefault();
                        if (v != null)
                        {
                            v.id_conductor = i.id_conductor;
                            v.nombre = i.nombre;
                            v.apellidos = i.apellidos;
                            v.domicilio = i.domicilio;
                            v.permiso = i.permiso;
                            v.disponibilidad = (bool)i.disponibilidad;
                            //MessageBox.Show("El Conductor " + v.id_conductor + " esta duplicado");
                        }
                        else
                        {
                            db.Conductor.Add(i);
                        }
                    }
                    MessageBox.Show("Se ha cargado el XML");
                    db.SaveChanges();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error al cargar el XML" + err.Message);
            }

            XDocument xDocM = XDocument.Load(@"mercancias.xml");

            try
            {

                List<Mercancia> mercancias = xDocM.Descendants("Mercancia").Select
                (mercancia =>
                new Mercancia
                {
                    id_producto = Int32.Parse(mercancia.Element("id_producto").Value),
                    nombre = mercancia.Element("nombre").Value,
                    volumenProducto = float.Parse(mercancia.Element("volumenProducto").Value)
                }
                ).ToList();

                using (netAssistantsEntities db = new netAssistantsEntities())
                {
                    foreach (var i in mercancias)
                    {
                        var v = db.Mercancia.Where(a => a.id_producto.Equals(i.id_producto)).FirstOrDefault();
                        if (v != null)
                        {
                            v.id_producto = i.id_producto;
                            v.nombre = i.nombre;
                            v.volumenProducto = i.volumenProducto;
                            MessageBox.Show("El Conductor " + v.id_producto + " esta duplicado");
                        }
                        else
                        {
                            db.Mercancia.Add(i);
                        }
                    }
                    MessageBox.Show("Se ha cargado el XML");
                    db.SaveChanges();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error al cargar el XML" + err);
            }
            /*using (netAssistantsEntities db = new netAssistantsEntities())
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"conductores.XML");
                
                List<string> entrada = new List<string>();

                foreach(DataTable dt in dataSet.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            entrada.Add(row[col].ToString());
                        }

                        Conductor c = new Conductor();

                        c.id_conductor = Int32.Parse(entrada[0]);
                        c.nombre = entrada[1];
                        c.apellidos = entrada[2];
                        c.domicilio = entrada[3];
                        c.permiso = entrada[4];
                        c.disponibilidad = bool.Parse(entrada[5]);

                        try
                        {
                            if(db.Conductors.Find(c.id_conductor) == null)
                            {
                                db.Conductors.Add(c);
                                db.SaveChanges();
                                MessageBox.Show("XML importado y anadido a la BD");
                            }
                            else
                            {
                                MessageBox.Show("El conductor esta duplicado " + c.id_conductor);
                            }
                            
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("PETO");
                        }
                        entrada.Clear();
                    }

                }
            }*/

            /*SqlConnection connection = new SqlConnection();

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

                string createTableStatementMercancia = "CREATE TABLE Mercancia(id_mercancia int PRIMARY KEY, nombre VARCHAR(10), volumenProducto FLOAT)";
                string createTableStatementVehiculo = "CREATE TABLE Vehiculo(id_vehiculo int PRIMARY KEY, marca VARCHAR(10), tipoVehiculo VARCHAR(10), disponibilidadVehiculo BIT, volumenGasolina FLOAT, estado BIT)";
                string createTableStatementConductor = "CREATE TABLE Conductor(id_conductor int PRIMARY KEY, nombre VARCHAR(10), apellidos VARCHAR(20), domicilio VARCHAR(15), permisoConducir VARCHAR(10), disponibilidad BIT)"; 
                string createTableStatementRuta = "CREATE TABLE Ruta(id_ruta int PRIMARY KEY, origen_ruta VARCHAR(10), destino_ruta VARCHAR(10), repostar_gasolina BIT, fecha_ruta DATE, duracion_ruta DATE, precio_repostaje FLOAT, kms_ruta FLOAT)";

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
                    MessageBox.Show("Tabla Mercancia creada");

                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }*/

        }
    }
}
