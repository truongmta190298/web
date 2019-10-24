namespace BTL_WED.Models.Emty
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Host")]
    public partial class Host
    {
        public int HostID { get; set; }

        [StringLength(100)]
        public string HostName { get; set; }

        [StringLength(100)]
        public string Avatar { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
    }
}
