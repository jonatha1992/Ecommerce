using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace React_Net.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Personaje> Personajes { get; set; } = new List<Personaje>();

        public Actor(int ID) { Id = ID; }
        public Actor() {  }
    }

    public class ActorCreacionDTO
    {
        [StringLength(150)]
        public string Nombre { get; set; } = null!;
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
    public class ActorDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }

    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {

            builder.ToTable(nameof(Actor));
            builder.Property(a => a.FechaNacimiento).HasColumnType("date");
            builder.Property(a => a.Fortuna).HasPrecision(18, 2);
        }
    }

}

