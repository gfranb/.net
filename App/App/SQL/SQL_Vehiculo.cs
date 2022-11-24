using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SQL
{
    public class SQL_Vehiculo
    {
        public List<string> buscarVehiculo(string id)
        {
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                List<Vehiculo> vehiculos = db.Vehiculo.ToList();
                foreach(Vehiculo vehic in vehiculos)
                {
                    if(vehic.id_vehiculo == Int32.Parse(id))
                    {
                        List<string> lista = new List<string>();
                        lista.Add(vehic.id_vehiculo.ToString());
                        lista.Add(vehic.marca.ToString());
                        lista.Add(vehic.tipoVehiculo.ToString());
                        lista.Add(vehic.disponibilidadVehiculo.ToString());
                        lista.Add(vehic.volumenGasolina.ToString());
                        lista.Add(vehic.estado.ToString());
                        return lista;
                    }
                }
                return null;

            }

        }

        public bool addVehiculo(List<string> listaVehiculo)
        {
            Vehiculo i = new Vehiculo();
            i.id_vehiculo = Int32.Parse(listaVehiculo[0]);
            i.marca = listaVehiculo[1];
            i.tipoVehiculo = listaVehiculo[2];
            i.disponibilidadVehiculo = false;
            i.volumenGasolina = (float)Int32.Parse(listaVehiculo[3]);   
            i.estado = false;

            using (netAssistantsEntities db = new netAssistantsEntities())
            {
               
                    var v = db.Vehiculo.Where(a => a.id_vehiculo.Equals(i.id_vehiculo)).FirstOrDefault();
                    if (v != null)
                    {
                        v.id_vehiculo = i.id_vehiculo;
                        v.marca = i.marca;
                        v.tipoVehiculo = i.tipoVehiculo;
                        v.disponibilidadVehiculo = i.disponibilidadVehiculo;
                        v.volumenGasolina = i.volumenGasolina;
                        v.estado = (bool)i.estado;
                        //MessageBox.Show("El Vehiculo " + v.id_vehiculo + " esta duplicado");
                    }
                    else
                    {
                        db.Vehiculo.Add(i);
                    }
                
                db.SaveChanges();

                return true;
            }
        }

        public bool eliminarVehiculo(string i)
        {
            int id = Int32.Parse(i);
            using (netAssistantsEntities db = new netAssistantsEntities())
            {

                var v = db.Vehiculo.Where(a => a.id_vehiculo.Equals(id)).FirstOrDefault();
                if (v != null)
                {
                    db.Vehiculo.Remove(v);
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

    }
}
