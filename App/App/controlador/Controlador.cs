using App.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.controlador
{
    internal class Controlador
    {
        public List<string> buscarMercancia(string id)
        {
            SQL.SQL_Mercancia sqlMercancia = new SQL.SQL_Mercancia();
            return sqlMercancia.buscarMercancia(id);
        }

        public bool addMercancia(List<string> listaM)
        {
            SQL.SQL_Mercancia sqlMercancia = new SQL.SQL_Mercancia();
            return sqlMercancia.addMercancia(listaM);
        }
        public bool deleteMercancia(string id)
        {
            SQL.SQL_Mercancia sqlMercancia = new SQL.SQL_Mercancia();
            return sqlMercancia.eliminarMercancia(id);
        }
        public List<string> buscarVehiculo(string id)
        {
            SQL.SQL_Vehiculo sqlVehiculo = new SQL.SQL_Vehiculo();
            return sqlVehiculo.buscarVehiculo(id);
        }
        public int gestionarRuta(List<string> data)
        {
            SQL.SQL_Conductor sqlConductor = new SQL.SQL_Conductor();
            SQL.SQL_Vehiculo sqlVehiculo = new SQL.SQL_Vehiculo();
            
            List<string> conductor = sqlConductor.buscarConductor(data[2]);
            List<string> vehiculo = sqlVehiculo.buscarVehiculo(data[3]);

            if (conductor[5] == "False")
            {
                return 1;
            } else if (vehiculo[4] == "False")
            {
                return 2;
            }else
            {
                SQL.SQL_GestionRuta gestionRuta = new SQL_GestionRuta();
                if(gestionRuta.newSolicitud(data[0], data[1], data[2], data[3], data[4], data[4]))
                {
                    return 0;
                }
                return 3;
            }
        }

        public void generarRutas()
        {
            Ruta ruta = new Ruta();
            ruta.id_ruta = 1;
            ruta.origen_ruta = "Barcelona";
            ruta.destino_ruta = "Madrid";
            ruta.repostar_gasolina = true;
            ruta.kms_ruta = 600;
            ruta.duracion = null;
            ruta.fecha_ruta = null;
            ruta.precio_repostaje = 40;

            Ruta ruta2 = new Ruta();
            ruta2.id_ruta = 1;
            ruta2.origen_ruta = "Barcelona";
            ruta2.destino_ruta = "Zaragoza";
            ruta2.repostar_gasolina = true;
            ruta2.kms_ruta = 310;
            ruta2.duracion = null;
            ruta2.fecha_ruta = null;
            ruta2.precio_repostaje = 40;

            Ruta ruta3 = new Ruta();
            ruta3.id_ruta = 1;
            ruta3.origen_ruta = "Barcelona";
            ruta3.destino_ruta = "Valencia";
            ruta3.repostar_gasolina = true;
            ruta3.kms_ruta = 260;
            ruta3.duracion = null;
            ruta3.fecha_ruta = null;
            ruta3.precio_repostaje = 40;

            using(netAssistantsEntities db = new netAssistantsEntities())
            {

                try
                {
                    db.Ruta.Add(ruta);
                    db.Ruta.Add(ruta2);
                    db.Ruta.Add(ruta3);
                }catch(Exception e)
                {

                }

            }
        }
        public bool addVehiculo(List<string> listav)
        {
            SQL.SQL_Vehiculo sqlVehiculo = new SQL.SQL_Vehiculo();
            return sqlVehiculo.addVehiculo(listav);
        }

        public bool eliminarVehiculo(string id)
        {
            SQL.SQL_Vehiculo sqlVehiculo = new SQL.SQL_Vehiculo();
            return sqlVehiculo.eliminarVehiculo(id);
        }

        public List<string> buscarConductor(string id)
        {
            SQL.SQL_Conductor sqlConductor = new SQL.SQL_Conductor();
            return sqlConductor.buscarConductor(id);
        }

        public bool addConductor(List<string> listaCon)
        {
            SQL.SQL_Conductor sqlConductor = new SQL.SQL_Conductor();
            return sqlConductor.addConductor(listaCon);
        }

        public bool deleteConductor(string idCon)
        {
            SQL.SQL_Conductor sqlConductor = new SQL.SQL_Conductor();
            return sqlConductor.eliminarConductor(idCon);
        }

        public bool editarConductor(List<string> listaCon)
        {
            SQL.SQL_Conductor sqlConductor = new SQL.SQL_Conductor();
            return sqlConductor.editarConductor(listaCon);

        }

    }
}
