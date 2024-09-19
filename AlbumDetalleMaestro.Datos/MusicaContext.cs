using AlbumDetalleMaestro.Modelo;
using Microsoft.EntityFrameworkCore;

namespace AlbumDetalleMaestro.Datos
{
    public class MusicaContext:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Cancion> Canciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexion = @"Data Source=.;Initial Catalog=AlbumDetalleMaestro;Integrated Security=True;";
            optionsBuilder.UseSqlServer(conexion);
        }
    }
}
