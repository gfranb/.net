//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conductor
    {
        public int id_conductor { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string domicilio { get; set; }
        public string permiso { get; set; }
        public Nullable<bool> disponibilidad { get; set; }
    }
}
