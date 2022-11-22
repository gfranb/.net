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

       
    }
}
