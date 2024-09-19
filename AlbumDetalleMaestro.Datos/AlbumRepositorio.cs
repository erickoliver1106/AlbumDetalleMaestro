using AlbumDetalleMaestro.Modelo;
using Dapper;

namespace AlbumDetalleMaestro.Datos
{
    public class AlbumRepositorio : GenericoRepositorio, IAlbumRepositorio
    {
        public bool ActualizarAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public bool EliminarAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public bool InsertarAlbum(Album album)
        {
            var db = dbConnection();

            var sql = @"
            INSERT INTO Albums(Id,Nombre,Autor,FechaLanzamiento)
            VALUES(@Id,@Nombre,@Autor,@FechaLanzamiento)";

            var result = db.Execute(sql,
                new
                {
                    album.Id,
                    album.Nombre,
                    album.Autor,
                    album.FechaLanzamiento,
                });
            return result > 0;
        }

        public List<Album> ObtenerAlbums()
        {
            throw new NotImplementedException();
        }
    }
}
