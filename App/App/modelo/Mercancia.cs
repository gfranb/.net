using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    internal class Mercancia
    {
        private string id_mercancia;
        private float volumenProducto;
        private string nombre;

        Mercancia(string id_mercancia, float volumenProducto, string nombre)
        {
            this.id_mercancia = id_mercancia;
            this.volumenProducto = volumenProducto;
            this.nombre = nombre;
        }

        Mercancia()
        {

        }

        public void set_id_mercancia(string id)
        {
            this.id_mercancia = id;
        }

        public void set_volumenProducto(float volumen)
        {
            this.volumenProducto = volumen;
        }

        public void set_nombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string get_nombre()
        {
            return this.nombre;
        }

        public string get_id_mercancia()
        {
            return this.id_mercancia;
        }

        public string get_volumenProducto()
        {
            return this.nombre;
        }

    }
}
