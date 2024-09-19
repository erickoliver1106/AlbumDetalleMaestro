using AlbumDetalleMaestro.Modelo;

namespace AlbumDetalleMaestro.Datos
{
    public interface IAlbumRepositorio
    {
        List<Album> ObtenerAlbums();
        bool InsertarAlbum(Album album);
        bool ActualizarAlbum(Album album);
        bool EliminarAlbum(Album album);
    }
}
