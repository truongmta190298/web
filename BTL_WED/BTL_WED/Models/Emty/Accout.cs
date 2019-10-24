namespace BTL_WED.Models.Emty
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accout")]
    public partial class Accout
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Pass { get; set; }
    }
}
