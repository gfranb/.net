using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    internal class Conductor
    {
        private int id_conductor;
        private string nombre;
        private string apellidos;
        private string domicilio;
        private string permisoConducir;
        private bool disponibilidad;
       

        Conductor(int id_conductor, string nombre, string apellidos,  string domicilio, string permisoConducir, bool disponibilidad)
        {
            this.id_conductor = id_conductor;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.domicilio = domicilio;
            this.permisoConducir = permisoConducir;
            this.disponibilidad = disponibilidad;
        }

        Conductor()
        {

        }

        public void set_id_conductor(int id)
        {
            this.id_conductor = id;
        }

        public void set_nombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void set_apellidos(string apellidos)
        {
            this.apellidos = apellidos;

        }
        
        public void set_domicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }
        public void set_permisoConducir(string permiso)
        {
            this.permisoConducir = permiso;
        }
        public void set_disponibilidad(bool disponibilidad)
        {
            this.disponibilidad = disponibilidad;
        }

        public int get_id_conductor()
        {
            return this.id_conductor;
        }

        public string get_nombre()
        {
            return this.nombre;
        }

        public string get_apellidos()
        {
            return this.apellidos;
        }
        
        public string get_domicilio()
        {
            return this.domicilio;
        }

        public string get_permisoConducir()
        {
            return this.permisoConducir;
        }
        

    }
}

