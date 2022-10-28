using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    internal class Conductor
    {
        private string id_conductor;
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;
        private string domicilio;
        private string permisoConducir;
        private Boolean disponibilidad;
        private id_pedido pedido;

        Conductor(string id_conductor, string nombre, string apellidos, DateTime fechaNacimiento, string domicilio, string permisoConducir, Boolean disponibilidad, id_pedido pedido)
        {
            this.id_conductor = id_conductor;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.domicilio = domicilio;
            this.permisoConducir = permisoConducir;
            this.disponibilidad = disponibilidad;
            this.pedido = pedido;
        }

        Conductor()
        {

        }

        public void set_id_conductor(string id)
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
        public void set_fechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public void set_domicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }
        public void set_permisoConducir(string permiso)
        {
            this.permisoConducir = permiso;
        }
        public void set_disponibilidad(Boolean disponibilidad)
        {
            this.disponibilidad = disponibilidad;
        }
        public void Set_id_pedido(id_pedido pedido)
        {
            this.id_pedido = pedido;
        }

        public string get_id_conductor()
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
        public string get_fechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public string get_domicilio()
        {
            return this.domicilio;
        }

        public string get_permisoConducir()
        {
            return this.permisoConducir;
        }
        public string get_disponibilidad()
        {
            return this.disponibilidad;
        }
        public string get_pedido()
        {
            return this.pedido;
        }


    }
}
}
