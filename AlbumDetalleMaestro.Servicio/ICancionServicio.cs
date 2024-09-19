using AlbumDetalleMaestro.Modelo;

namespace AlbumDetalleMaestro.Servicio
{
    public interface ICancionServicio
    {
        List<Cancion> ObtenerCanciones();
        bool GuardarCancion(Cancion cancion);
        bool EliminarCancion(Cancion cancion);
    }
}
