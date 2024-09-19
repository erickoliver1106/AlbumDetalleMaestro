namespace AlbumDetalleMaestro.Modelo
{
    public class Cancion
    {
        public Guid Id { get; set; }
        public Guid AlbumId { get; set; }
        public string Nombre { get; set; }
        public int Minutos { get; set; }
    }
}
