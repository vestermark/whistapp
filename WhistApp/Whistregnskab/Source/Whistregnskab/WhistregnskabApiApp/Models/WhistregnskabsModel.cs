namespace WhistregnskabApiApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WhistregnskabsModel : DbContext
    {
        public WhistregnskabsModel()
            : base("name=WhistregnskabsModel")
        {
        }

        public virtual DbSet<Pulje> Puljer { get; set; }
        public virtual DbSet<Runde> Runder { get; set; }
        public virtual DbSet<Spil> Spil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
