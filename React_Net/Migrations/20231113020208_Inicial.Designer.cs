﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using React_Net;

#nullable disable

namespace React_Net.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231113020208_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");

                    b.HasData(
                        new
                        {
                            GenerosId = 5,
                            PeliculasId = 2
                        },
                        new
                        {
                            GenerosId = 5,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosId = 6,
                            PeliculasId = 4
                        });
                });

            modelBuilder.Entity("React_Net.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<decimal>("Fortuna")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Actor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortuna = 15000m,
                            Nombre = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortuna = 18000m,
                            Nombre = "Robert Downey Jr."
                        });
                });

            modelBuilder.Entity("React_Net.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<bool>("Recomendar")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Comentario", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Contenido = "Muy buena!!!",
                            PeliculaId = 2,
                            Recomendar = true
                        },
                        new
                        {
                            Id = 3,
                            Contenido = "Dura dura",
                            PeliculaId = 2,
                            Recomendar = true
                        },
                        new
                        {
                            Id = 4,
                            Contenido = "no debieron hacer eso...",
                            PeliculaId = 3,
                            Recomendar = false
                        });
                });

            modelBuilder.Entity("React_Net.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Genero", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Nombre = "Ciencia Ficcion"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Animacion"
                        });
                });

            modelBuilder.Entity("React_Net.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EnCines")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Pelicula", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            EnCines = false,
                            FechaEstreno = new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Avengers Endgame"
                        },
                        new
                        {
                            Id = 3,
                            EnCines = false,
                            FechaEstreno = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Spider-Man: No Way Home"
                        },
                        new
                        {
                            Id = 4,
                            EnCines = false,
                            FechaEstreno = new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Spider-Man: Across the Spider-Verse (Part One)"
                        });
                });

            modelBuilder.Entity("React_Net.Models.Personaje", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Personaje", (string)null);

                    b.HasData(
                        new
                        {
                            ActorId = 2,
                            PeliculaId = 3,
                            Nombre = "Nick Fury",
                            Orden = 1
                        },
                        new
                        {
                            ActorId = 2,
                            PeliculaId = 2,
                            Nombre = "Nick Fury",
                            Orden = 2
                        },
                        new
                        {
                            ActorId = 3,
                            PeliculaId = 2,
                            Nombre = "Iron Man",
                            Orden = 1
                        });
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("React_Net.Models.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("React_Net.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("React_Net.Models.Comentario", b =>
                {
                    b.HasOne("React_Net.Models.Pelicula", "Pelicula")
                        .WithMany("Comentarios")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("React_Net.Models.Personaje", b =>
                {
                    b.HasOne("React_Net.Models.Actor", "Actor")
                        .WithMany("Personajes")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("React_Net.Models.Pelicula", "Pelicula")
                        .WithMany("Personajes")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("React_Net.Models.Actor", b =>
                {
                    b.Navigation("Personajes");
                });

            modelBuilder.Entity("React_Net.Models.Pelicula", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
