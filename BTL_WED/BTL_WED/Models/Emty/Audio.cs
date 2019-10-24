namespace BTL_WED.Models.Emty
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Audio")]
    public partial class Audio
    {
        public int AudioID { get; set; }

        public int? HouseID { get; set; }

        [StringLength(200)]
        public string URL { get; set; }
    }
}
