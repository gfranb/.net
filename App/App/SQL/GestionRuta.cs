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
    
    public partial class GestionRuta
    {
        public int id_GestionRuta { get; set; }
        public Nullable<double> volumen { get; set; }
        public Nullable<System.DateTime> fechaEnvio { get; set; }
        public Nullable<int> id_conductor { get; set; }
        public Nullable<int> id_mercancia { get; set; }
        public Nullable<int> id_vehiculo { get; set; }
        public Nullable<int> id_ruta { get; set; }
    }
}
