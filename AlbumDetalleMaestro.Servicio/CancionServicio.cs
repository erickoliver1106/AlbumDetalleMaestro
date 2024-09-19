using AlbumDetalleMaestro.Datos;
using AlbumDetalleMaestro.Modelo;

namespace AlbumDetalleMaestro.Servicio
{
    public class CancionServicio : ICancionServicio
    {
        private ICancionRepositorio _repositorio;
        public CancionServicio()
        {
            _repositorio = new CancionRepositorio();
        }
        public bool EliminarCancion(Cancion cancion)
        {
            throw new NotImplementedException();
        }

        public bool GuardarCancion(Cancion cancion)
        {
            bool ok;

            if (cancion.Id == Guid.Empty)
                ok = _repositorio.InsertarCancion(cancion);
            else
                ok = _repositorio.ActualizarCancion(cancion);

            return ok;            
        }

        public List<Cancion> ObtenerCanciones()
        {
            throw new NotImplementedException();
        }
    }
}
