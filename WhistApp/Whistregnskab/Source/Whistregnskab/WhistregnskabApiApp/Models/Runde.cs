namespace WhistregnskabApiApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Runder")]
    public partial class Runde
    {
        [Key]
        public int RundeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Dato { get; set; }

        [StringLength(50)]
        public string Sted { get; set; }

        [StringLength(50)]
        public string Bem { get; set; }

        public int? Point1 { get; set; }

        public int? Point2 { get; set; }

        public int? Point3 { get; set; }

        public int? Point4 { get; set; }

        public int? PuljeId { get; set; }
    }
}

