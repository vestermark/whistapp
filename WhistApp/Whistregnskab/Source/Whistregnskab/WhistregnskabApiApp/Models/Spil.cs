namespace WhistregnskabApiApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Spil")]
    public partial class Spil
    {
        [Key]
        public int SpilId { get; set; }

        public DateTime Tidspunkt { get; set; }

        public int Melder { get; set; }

        public int Melding { get; set; }

        public int Makker { get; set; }

        public int Stik { get; set; }
        
        public int Point1 { get; set; }

        public int Point2 { get; set; }

        public int Point3 { get; set; }

        public int Point4 { get; set; }

        public int RundeId { get; set; }
    }
}
