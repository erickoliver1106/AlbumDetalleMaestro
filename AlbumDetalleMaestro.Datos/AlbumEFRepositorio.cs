using AlbumDetalleMaestro.Modelo;
using Microsoft.EntityFrameworkCore;

namespace AlbumDetalleMaestro.Datos
{
    public class AlbumEFRepositorio : IAlbumRepositorio
    {
        private MusicaContext _db;

        public AlbumEFRepositorio()
        {
            _db = new MusicaContext();
        }

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
            _db.Albums.Add(album);
            return true;
        }

        public List<Album> ObtenerAlbums()
        {
            throw new NotImplementedException();
        }
    }
}
