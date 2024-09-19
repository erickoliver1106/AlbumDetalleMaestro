using AlbumDetalleMaestro.Modelo;

namespace AlbumDetalleMaestro.Servicio
{
    public interface IAlbumServicio
    {
        List<Album> ObtenerAlbums();
        bool GuardarAlbum(Album album);
        bool EliminarAlbum(Album album);
        bool GuardarAlbum2(Album album);
    }
}
