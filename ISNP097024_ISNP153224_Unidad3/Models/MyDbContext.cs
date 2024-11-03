using Microsoft.EntityFrameworkCore;
namespace ISNP097024_ISNP153224_Unidad3.Models
{
    public class MyDbContext: DbContext{
            public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
            public DbSet<Pelicula> Pelicula { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(pelicula => pelicula.idPelicula);
        }
    }
}
