

namespace App.SQL
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Ruta")]
    [XmlRootAttribute("Ruta", IsNullable = false)]
    public partial class Ruta
    {
<<<<<<< HEAD
        [Key]
        public string id_ruta { get; set; }
        [Column("origen_ruta")]
        [StringLength(10)]
=======
        public int id_ruta { get; set; }
>>>>>>> produccion
        public string origen_ruta { get; set; }
        [Column("destino_ruta")]
        [StringLength(10)]
        public string destino_ruta { get; set; }
        [Column("repostar_gasolina")]
        public Nullable<bool> repostar_gasolina { get; set; }
        [Column("fecha_ruta")]
        public Nullable<System.DateTime> fecha_ruta { get; set; }
<<<<<<< HEAD
        [Column("duracion_ruta")]
        public Nullable<System.DateTime> duracion_ruta { get; set; }
        [Column("precio_repostaje")]
=======
        public Nullable<System.DateTime> duracion { get; set; }
>>>>>>> produccion
        public Nullable<double> precio_repostaje { get; set; }
        [Column("kms_ruta")]
        public Nullable<double> kms_ruta { get; set; }
    }
}
