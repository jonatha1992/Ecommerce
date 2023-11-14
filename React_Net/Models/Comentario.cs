using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace React_Net.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string? Contenido { get; set; }
        public bool Recomendar { get; set; 
        }
        public int PeliculaId { get; set; }
        public Pelicula? Pelicula { get; set; }  

        public Comentario() {  }
        public Comentario(int ID) { Id = ID;}
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
            try
            {
                builder.ToTable(nameof(Comentario));

                builder.HasKey(c => c.Id);

                builder.Property(a => a.Contenido).HasMaxLength(500);
                builder.HasOne(c => c.Pelicula)
                  .WithMany(p => p.Comentarios)
                   .HasForeignKey( c => c.PeliculaId)
                   .IsRequired();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

        }
    }
}