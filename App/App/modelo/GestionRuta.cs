using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.modelo;

namespace App.modelo
{
    internal class GestionRuta
    {
        private string id_GestionRuta;
        private double volumen;
        private DateTime fechaEnvio;
        private Conductor conductor;
        private Mercancia mercancia;
        private Vehiculo vohiculo;
        private Ruta ruta;        


        public GestionRuta(string id_GestionRuta, double volumen, DateTime fechaEnvio)
        {
            this.id_GestionRuta = id_GestionRuta;
            this.volumen = volumen;
            this.fechaEnvio = fechaEnvio;
        }

        public GestionRuta(string id_GestionRuta, double volumen, DateTime fechaEnvio, Conductor conductor, Mercancia mercancia, Vehiculo vohiculo, Ruta ruta) : this(id_GestionRuta, volumen, fechaEnvio)
        {
            this.id_GestionRuta = id_GestionRuta;
            this.volumen = volumen;
            this.fechaEnvio = fechaEnvio;
            this.conductor = conductor;
            this.mercancia = mercancia;
            this.vohiculo = vohiculo;
            this.ruta = ruta;
        }

        public GestionRuta()
        {
        }
        public string getIdGestionRuta()
        {

            return this.id_GestionRuta;
        }
        public void setIdGestionRuta(string idGestionRuta)
        {
            this.id_GestionRuta = idGestionRuta;
        }
        public double getVolumen()
        {
            return this.volumen;
        }
        public void setVolumen(double volumen)
        {
            this.volumen = volumen;
        }
        public DateTime getFechaEnvio()
        {
            return this.fechaEnvio;
        }
        public void setFechaEnvio(DateTime fecha)
        {
            this.fechaEnvio = fecha;
        }
    }
}
