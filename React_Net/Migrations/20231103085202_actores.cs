using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace React_Net.Migrations
{
    /// <inheritdoc />
    public partial class actores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Pelicula_PeliculaId",
                table: "Comentario");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Genero_GenerosId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Pelicula_PeliculasId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaActor_Actor_ActorId",
                table: "PeliculaActor");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaActor_Pelicula_PeliculaId",
                table: "PeliculaActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeliculaActor",
                table: "PeliculaActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genero",
                table: "Genero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "PeliculaActor",
                newName: "PeliculasActores");

            migrationBuilder.RenameTable(
                name: "Pelicula",
                newName: "Peliculas");

            migrationBuilder.RenameTable(
                name: "Genero",
                newName: "Generos");

            migrationBuilder.RenameTable(
                name: "Comentario",
                newName: "Comentarios");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actores");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculaActor_PeliculaId",
                table: "PeliculasActores",
                newName: "IX_PeliculasActores_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Genero_Nombre",
                table: "Generos",
                newName: "IX_Generos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Comentario_PeliculaId",
                table: "Comentarios",
                newName: "IX_Comentarios_PeliculaId");

            migrationBuilder.AlterColumn<string>(
                name: "Personaje",
                table: "PeliculasActores",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Peliculas",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Generos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Actores",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeliculasActores",
                table: "PeliculasActores",
                columns: new[] { "ActorId", "PeliculaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actores",
                table: "Actores",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "FechaNacimiento", "Fortuna", "Nombre" },
                values: new object[,]
                {
                    { 2, new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "Samuel L. Jackson" },
                    { 3, new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000m, "Robert Downey Jr." }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "EnCines", "FechaEstreno", "Titulo" },
                values: new object[,]
                {
                    { 2, false, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers Endgame" },
                    { 3, false, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: No Way Home" },
                    { 4, false, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: Across the Spider-Verse (Part One)" }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "Id", "Contenido", "PeliculaId", "Recomendar" },
                values: new object[,]
                {
                    { 2, "Muy buena!!!", 2, true },
                    { 3, "Dura dura", 2, true },
                    { 4, "no debieron hacer eso...", 3, false }
                });

            migrationBuilder.InsertData(
                table: "GeneroPelicula",
                columns: new[] { "GenerosId", "PeliculasId" },
                values: new object[,]
                {
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "PeliculasActores",
                columns: new[] { "ActorId", "PeliculaId", "Orden", "Personaje" },
                values: new object[,]
                {
                    { 2, 2, 2, "Nick Fury" },
                    { 2, 3, 1, "Nick Fury" },
                    { 3, 2, 1, "Iron Man" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Peliculas_PeliculaId",
                table: "Comentarios",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Generos_GenerosId",
                table: "GeneroPelicula",
                column: "GenerosId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Peliculas_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Actores_ActorId",
                table: "PeliculasActores",
                column: "ActorId",
                principalTable: "Actores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Peliculas_PeliculaId",
                table: "PeliculasActores",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Peliculas_PeliculaId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Generos_GenerosId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Peliculas_PeliculasId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Actores_ActorId",
                table: "PeliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Peliculas_PeliculaId",
                table: "PeliculasActores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeliculasActores",
                table: "PeliculasActores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actores",
                table: "Actores");

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "PeliculasActores",
                newName: "PeliculaActor");

            migrationBuilder.RenameTable(
                name: "Peliculas",
                newName: "Pelicula");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "Genero");

            migrationBuilder.RenameTable(
                name: "Comentarios",
                newName: "Comentario");

            migrationBuilder.RenameTable(
                name: "Actores",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculasActores_PeliculaId",
                table: "PeliculaActor",
                newName: "IX_PeliculaActor_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Generos_Nombre",
                table: "Genero",
                newName: "IX_Genero_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_PeliculaId",
                table: "Comentario",
                newName: "IX_Comentario_PeliculaId");

            migrationBuilder.AlterColumn<string>(
                name: "Personaje",
                table: "PeliculaActor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Pelicula",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Genero",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeliculaActor",
                table: "PeliculaActor",
                columns: new[] { "ActorId", "PeliculaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genero",
                table: "Genero",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Pelicula_PeliculaId",
                table: "Comentario",
                column: "PeliculaId",
                principalTable: "Pelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Genero_GenerosId",
                table: "GeneroPelicula",
                column: "GenerosId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Pelicula_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId",
                principalTable: "Pelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaActor_Actor_ActorId",
                table: "PeliculaActor",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaActor_Pelicula_PeliculaId",
                table: "PeliculaActor",
                column: "PeliculaId",
                principalTable: "Pelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
