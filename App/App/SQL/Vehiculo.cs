
namespace App.SQL
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Vehiculo")]
    [XmlRootAttribute("Vehiculo", IsNullable = false)]
    public partial class Vehiculo
    {
        [Key]
        [Column("id_vehiculo")]
        public int id_vehiculo { get; set; }
        [Column("marca")]
        [StringLength(10)]
        public string marca { get; set; }
        [Column("tipoVehiculo")]
        [StringLength(10)]
        public string tipoVehiculo { get; set; }
        [Column("disponibilidadVehiculo")]
        public Nullable<bool> disponibilidadVehiculo { get; set; }
        [Column("volumenGasolina")]
        public Nullable<double> volumenGasolina { get; set; }
        [Column("estado")]
        public Nullable<bool> estado { get; set; }
    }
}
