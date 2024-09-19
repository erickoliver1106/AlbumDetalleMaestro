namespace AlbumDetalleMaestro.Modelo
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public List<Cancion> Canciones { get; set; }
    }
}
