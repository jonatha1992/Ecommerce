﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace React_Net.Models.Config
{
    public class ComentarioConfig : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.Property(a => a.Contenido).HasMaxLength(500);
        }
    }
}
