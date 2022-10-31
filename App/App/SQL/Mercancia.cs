

namespace App.SQL
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Mercancia")]
    [XmlRootAttribute("Mercancia", IsNullable = false)]
    public partial class Mercancia
    {
        [Key]
        public string id_mercancia { get; set; }
        [Column("nombre")]
        [StringLength(10)]
        public string nombre { get; set; }
        [Column("volumenProducto")]
        public Nullable<double> volumenProducto { get; set; }
    }
}
