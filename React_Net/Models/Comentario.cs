using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace React_Net.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string? Contenido { get; set; }
        public bool Recomendar { get; set; }
        //public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
    }

    public class ComentarioCreacionDTO
    {
        public string? Contenido { get; set; }
        public bool Recomendar { get; set; }
    }

    public class ComentarioConfig : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.Property<int>("PeliculaId");
            builder.HasOne(c => c.Pelicula)
                   .WithMany()
                   .HasForeignKey("PeliculaId");

            builder.HasKey(c => c.Id);

            builder.Property(a => a.Contenido).HasMaxLength(500);
        }
    }
}