using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo {
    internal class Ruta
    {

        private string id_ruta;
        private string origen_ruta;
        private string destino_ruta;
        private bool repostar_gasolina;
        private string gasolinera;
        private DateTime fecha_ruta;
        private DateTime duracion_ruta;
        private float precio_repostaje;
        private float kms_ruta;

        Ruta(string id_ruta, string origen_ruta, string destino_ruta, bool repostar_gasolina, string gasolinera, DateTime fecha_ruta,
            DateTime duracion_ruta, float precio_repostaje, float kms_ruta)
        {
            this.id_ruta = id_ruta;
            this.origen_ruta = origen_ruta;
            this.destino_ruta = destino_ruta;
            this.repostar_gasolina = repostar_gasolina;
            this.gasolinera = gasolinera;
            this.fecha_ruta = fecha_ruta;
            this.duracion_ruta = duracion_ruta;
            this.precio_repostaje = precio_repostaje;
            this.kms_ruta = kms_ruta;
        }

        Ruta()
        {

        }

        public void set_id_ruta(string id)
        {
            this.id_ruta = id;
        }

        public void set_origen_ruta(string origen)
        {
            this.origen_ruta = origen;
        }

        public void set_destino_ruta(string destino)
        {
            this.destino_ruta = destino;
        }
        public void set_repostar_gasolina(bool repostar)
        {
            this.repostar_gasolina = repostar;
        }
        public void set_gasolinera(string gasolinera)
        {
            this.gasolinera = gasolinera;
        }
        public void set_fecha_ruta(DateTime fecha_hora)
        {
            this.fecha_ruta = fecha_hora;
        }
        public void set_duracion_ruta(DateTime duracion)
        {
            this.duracion_ruta = duracion;
        }
        public void set_precio_repostaje(float precio_gasolina)
        {
            this.precio_repostaje = precio_gasolina;
        }
        public void set_kms_ruta(float kms)
        {
            this.kms_ruta = kms;
        }


        public string get_id_ruta()
        {
            return this.id_ruta;
        }

        public string get_origen_ruta()
        {
            return this.origen_ruta;
        }

        public string get_destino_ruta()
        {
            return this.destino_ruta;
        }

        public bool get_repostar_gasolina()
        {
            return this.repostar_gasolina;
        }

        public string get_gasolinera()
        {
            return this.gasolinera;
        }

        public DateTime get_fecha_ruta()
        {
            return this.fecha_ruta;
        }

        public DateTime get_duracion_ruta()
        {
            return this.duracion_ruta;
        }

        public float get_precio_repostaje()
        {
            return this.precio_repostaje;
        }

        public float get_kms_ruta()
        {
            return this.kms_ruta;
        }
    }
}

