using EmbroideryThreadsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmbroideryThreadsApi.Data
{
    public class EmbroideryThreadsContext : DbContext
    {
        public EmbroideryThreadsContext (DbContextOptions options) : base(options)
        {
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Anchor> Anchor { get; set; }
        public DbSet<Dimensions> Dimensions { get; set; }
        public DbSet<DMC> DMCs { get; set; }
        public DbSet<Presencia> Presencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 1, ColorName = "Fuschia", HexCode = "9C599C" },
                new Color { ColorId = 2, ColorName = "White", HexCode = "FFFFFF"}
            );
        }

    }
}
