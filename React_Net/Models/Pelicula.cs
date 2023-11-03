namespace React_Net.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>();
        public List<Genero> Generos { get; set; } = new List<Genero>();
        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();
    }
}