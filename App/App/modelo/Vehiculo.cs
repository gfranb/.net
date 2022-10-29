using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.modelo
{
    class Vehiculo
    {
        private string id_vehiculo;
        private string marca;
        private string tipoVehiculo;
        private bool disponibilidadVehiculo;
        private double volumenGasolina;
        private bool estado;

        public Vehiculo()
        {
        }

        public Vehiculo(string id_vehiculo, string marca, string tipoVehiculo, bool disponibilidadVehiculo, double volumenGasolina, bool estado)
        {
            this.id_vehiculo = id_vehiculo;
            this.marca = marca;
            this.tipoVehiculo = tipoVehiculo;
            this.disponibilidadVehiculo = disponibilidadVehiculo;
            this.volumenGasolina = volumenGasolina;
            this.estado = estado;
        }

        public void setId_vehiculo(string id)
        {
            this.id_vehiculo = id;
        }

        public string getId_vehiculo()
        {
            return this.id_vehiculo;
        }


        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return this.marca;
        }


        public void setTipoVehiculo(string tipoVehiculo)
        {
            this.tipoVehiculo = tipoVehiculo;
        }

        public string getTipoVehiculo()
        {
            return this.tipoVehiculo;
        }


        public void setDisponibilidadVehiculo (bool disponibilidadVehiculo)
        {
            this.disponibilidadVehiculo = disponibilidadVehiculo;
        }

        public bool getDisponibilidadVehiculo()
        {
            return this.disponibilidadVehiculo;
        }


        public void setVolumenGasolina (double volumenGasolina)
        {
            this.volumenGasolina = volumenGasolina;
        }

        public double getVolumenGasolina()
        {
            return this.volumenGasolina;
        }


        public void setEstado (bool estado)
        {
            this.estado = estado;
        }

        public bool getEstado()
        {
            return this.estado;
        }
        public override string ToString()
        {
            return "El vehiculo con Id: " + getId_vehiculo() + ", " + "es de la marca " + getMarca() + ", " + "es de tipo " + getTipoVehiculo() + ". ";
        }
    }
   
}
