namespace Greenery
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GreeneryEntityModel : DbContext
    {
        public GreeneryEntityModel()
            : base("name=GreeneryEntityModel1")
        {
        }

        public virtual DbSet<Greenery> Greeneries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Greenery>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();
        }
    }
}
