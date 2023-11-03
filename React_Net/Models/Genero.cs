using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace React_Net.Models
{
    public class Genero
    {
        public Genero() { }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public List<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}
