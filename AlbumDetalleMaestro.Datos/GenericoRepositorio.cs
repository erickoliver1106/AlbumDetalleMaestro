using System.Data.SqlClient;

namespace AlbumDetalleMaestro.Datos
{
    public abstract class GenericoRepositorio
    {
        protected SqlConnection dbConnection()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=AlbumDetalleMaestro;Integrated Security=True;");
        }
    }
}
