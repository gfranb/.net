using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SQL
{
    internal class SQL_Vehiculo
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
    }
}
