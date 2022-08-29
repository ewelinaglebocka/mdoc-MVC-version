using mdoc.DataBase.Models;
using mdoc.DataBase.Models.Dokumentacja_wykonawcza;
using Microsoft.EntityFrameworkCore;

namespace mdoc
{
    public class mdocContext : DbContext
    {
        public mdocContext(DbContextOptions<mdocContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<dokumenty> documents { get; set; }
        public DbSet<produkty> products { get; set; }
    }
}
