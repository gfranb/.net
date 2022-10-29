using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.modelo
{
    class ListaVehiculo
    {
        private List<Vehiculo> listVehiculo;

        public ListaVehiculo()
        {
        }

        public ListaVehiculo(List<Vehiculo> listVehiculo)
        {
            this.listVehiculo = listVehiculo;
        }

        public void setListaVehiculo(List<Vehiculo> listVehiculo)
        {
            this.listVehiculo = listVehiculo;
        }

        public List<Vehiculo> getListaVehiculo()
        {
            return listVehiculo;
        }

          
    }

}
