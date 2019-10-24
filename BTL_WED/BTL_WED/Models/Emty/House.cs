namespace BTL_WED.Models.Emty
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("House")]
    public partial class House
    {
        public int HouseID { get; set; }

        [StringLength(100)]
        public string Avatar { get; set; }

        [StringLength(200)]
        public string Location { get; set; }

        [StringLength(50)]
        public string PropertyType { get; set; }

        [Column("_Status")]
        [StringLength(50)]
        public string C_Status { get; set; }

        public int? Area { get; set; }

        public int? Beds { get; set; }

        public int? Baths { get; set; }

        public int? Garage { get; set; }

        public string PropertyDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLine { get; set; }

        [StringLength(200)]
        public string Map { get; set; }

        public int? HostID { get; set; }

        public int? Price { get; set; }
    }
}
