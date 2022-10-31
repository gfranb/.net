using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    internal class Mercancia
    {
        private int id_mercancia;
        private double volumenProducto;
        private string nombre;

        Mercancia(int id_mercancia, double volumenProducto, string nombre)
        {
            this.id_mercancia = id_mercancia;
            this.volumenProducto = volumenProducto;
            this.nombre = nombre;
        }

        Mercancia()
        {

        }

        public void set_id_mercancia(int id)
        {
            this.id_mercancia = id;
        }

        public void set_volumenProducto(double volumen)
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

        public int get_id_mercancia()
        {
            return this.id_mercancia;
        }

        public double get_volumenProducto()
        {
            return this.volumenProducto;
        }
      

    }
}
