using AlbumDetalleMaestro.Modelo;

namespace AlbumDetalleMaestro.Datos
{
    public interface ICancionRepositorio
    {
        List<Cancion> ObtenerCanciones();
        bool InsertarCancion(Cancion cancion);
        bool ActualizarCancion(Cancion cancion);
        bool EliminarCancion(Cancion cancion);
    }
}
