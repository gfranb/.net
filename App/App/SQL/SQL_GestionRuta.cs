using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SQL
{
    public class SQL_GestionRuta
    {
        public bool newSolicitud(string gestion_ruta, string idRuta, string idConductor, string idMercancia, string idVehiculo, string v)
        {
            int _gestion_ruta = Int32.Parse(gestion_ruta);

            using(netAssistantsEntities db = new netAssistantsEntities())
            {
                GestionRuta pedido = new GestionRuta();
                pedido.id_GestionRuta = Int32.Parse(gestion_ruta);
                pedido.id_ruta = Int32.Parse(idRuta);
                pedido.id_conductor = Int32.Parse(idConductor);
                pedido.id_mercancia = Int32.Parse(idMercancia);
                pedido.id_vehiculo = Int32.Parse(idVehiculo);
                pedido.volumen = float.Parse(gestion_ruta);
                DateTime thisDay = DateTime.Today;
                pedido.fechaEnvio = thisDay;

                var _v = db.GestionRuta.Where(a => a.id_GestionRuta.Equals(pedido.id_GestionRuta)).FirstOrDefault();
                if (_v != null)
                {
                    _v.id_GestionRuta = pedido.id_GestionRuta;
                    _v.id_ruta = pedido.id_ruta;
                    _v.id_conductor = pedido.id_conductor;
                    _v.id_mercancia = pedido.id_mercancia;
                    _v.id_vehiculo = pedido.id_vehiculo;
                    _v.volumen = pedido.volumen;
                    _v.fechaEnvio = pedido.fechaEnvio;
                    return false;
                }
                else
                {
                    db.GestionRuta.Add(pedido);
                    db.SaveChanges();
                    return true;
                }
                
            }
        }
    }
}
