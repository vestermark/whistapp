namespace WhistregnskabApiApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Puljer")]
    public partial class Pulje
    {
        [Key]
        public int PuljeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Navn { get; set; }

        [StringLength(50)]
        public string Ejer { get; set; }

        [Column(TypeName = "date")]
        public DateTime Oprettelsesdato { get; set; }

        [StringLength(50)]
        public string Spiller1 { get; set; }

        public int? Point1 { get; set; }

        [StringLength(50)]
        public string Spiller2 { get; set; }

        public int? Point2 { get; set; }

        [StringLength(50)]
        public string Spiller3 { get; set; }

        public int? Point3 { get; set; }

        [StringLength(50)]
        public string Spiller4 { get; set; }

        public int? Point4 { get; set; }
    }
}
