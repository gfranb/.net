
namespace App.SQL
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Conductor")]
    [XmlRootAttribute("Conductor", IsNullable = false)]
    public partial class Conductor
    {
        [Key]
        public int id_conductor { get; set; }
        [Column("nombre")]
        [StringLength(100)]
        public string nombre { get; set; }
        [Column("apellidos")]
        [StringLength(20)]
        public string apellidos { get; set; }
        [Column("domicilio")]
        [StringLength(15)]
        public string domicilio { get; set; }
        [Column("permiso")]
        [StringLength(10)]
        public string permiso { get; set; }
        [Column("disponibilidad")]
        public Nullable<bool> disponibilidad { get; set; }
    }
}
