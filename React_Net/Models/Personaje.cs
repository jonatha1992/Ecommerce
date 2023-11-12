using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace React_Net.Models
{
    public class Personaje
    {
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
        public int ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Orden { get; set; }
    }

    public class PersonajeCreacionDTO
    {
        public int ActorId { get; set; }
        public string Nombre { get; set; } = null!;
    }

    public class PersonajeConfig : IEntityTypeConfiguration<Personaje>
    {
        public void Configure(EntityTypeBuilder<Personaje> builder)
        {
            builder.ToTable(nameof(Personaje));
   
            builder.HasKey(pe => new { pe.ActorId, pe.PeliculaId });
        }
    }
}