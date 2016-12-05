namespace Greenery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Greenery")]
    public partial class Greenery
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TimeStamp { get; set; }

        [Required]
        [StringLength(50)]
        public string Temperature { get; set; }

        [Required]
        [StringLength(50)]
        public string Humidity { get; set; }

        [Required]
        [StringLength(50)]
        public string Average { get; set; }
    }
}
