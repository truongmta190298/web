namespace BTL_WED.Models.Emty
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("name=MyDBContext100")
        {
        }

        public virtual DbSet<Accout> Accouts { get; set; }
        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Host> Hosts { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accout>()
                .Property(e => e.Pass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Host>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
