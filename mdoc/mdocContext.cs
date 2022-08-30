using mdoc.Models.Dokumentacja_wykonawcza;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace mdoc
{
    public class mdocContext : IdentityDbContext
    {
        public mdocContext(DbContextOptions<mdocContext> options) : base(options)
        {
        }

        public DbSet<Dokumenty> dokumenty { get; set; }
        public DbSet<Produkty> produkty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseFirebird("Server=192.168.2.89;Database=C:\\zmiana_technologii\\MARDOM_ALL.FDB;Trusted_Connection=True;MultipleActiveResultSets=True;UserID=SYSDBA;Password=masterkey;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
