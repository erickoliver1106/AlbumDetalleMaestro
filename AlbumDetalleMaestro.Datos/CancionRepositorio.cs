using AlbumDetalleMaestro.Modelo;
using Dapper;

namespace AlbumDetalleMaestro.Datos
{
    public class CancionRepositorio : GenericoRepositorio, ICancionRepositorio
    {
        public bool ActualizarCancion(Cancion cancion)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCancion(Cancion cancion)
        {
            throw new NotImplementedException();
        }

        public bool InsertarCancion(Cancion cancion)
        {
            var db = dbConnection();

            var sql = @"
                      INSERT INTO Canciones(AlbumId,Nombre,Minutos)
                      VALUES(@AlbumId,@Nombre,@Minutos)";

            var result = db.Execute(sql,
                new { cancion.AlbumId, cancion.Nombre, cancion.Minutos });

            return result > 0;
        }

        public List<Cancion> ObtenerCanciones()
        {
            throw new NotImplementedException();
        }
    }
}
