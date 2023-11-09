using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace React_Net.Models
{
    public class Personaje
    {
        //public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
        //public int ActorId { get; set; }
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

            builder.Property<int>("PeliculaId");
            builder.Property<int>("ActorId");


            builder.HasKey("PeliculaId", "ActorId");

            // Mapea las relaciones con shadow FK
            builder.HasOne(p => p.Pelicula)
                   .WithMany()
                   .HasForeignKey("PeliculaId");

            builder.HasOne(p => p.Actor)
                   .WithMany()
                   .HasForeignKey("ActorId");


            //builder.HasKey(pa => new { pa.ActorId, pa.PeliculaId });
            //builder.HasKey(p => new { PeliculaId = p.Pelicula.Id, ActorId = p.Actor.Id });
        }
    }
}