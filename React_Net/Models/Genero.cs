using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace React_Net.Models
{
    public class Genero
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public List<Pelicula> Peliculas { get; set; } = new List<Pelicula>();

        public Genero() { }
        public Genero(int id) { Id = id; }

    }

    public class GeneroCreacionDTO
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }

    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            //var cienciaFiccion = new Genero { Id = 5, Nombre = "Ciencia Ficción" };
            //var animacion = new Genero { Id = 6, Nombre = "Animación" };
            //builder.HasData(cienciaFiccion, animacion);

            builder.ToTable(nameof(Genero));
            builder.HasIndex(p => p.Nombre).IsUnique();
        }
    }
}
