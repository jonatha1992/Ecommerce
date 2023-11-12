using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace React_Net.Migrations
{
    /// <inheritdoc />
    public partial class comentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Personaje",
                table: "Personaje");

            migrationBuilder.DropIndex(
                name: "IX_Personaje_ActorId",
                table: "Personaje");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personaje",
                table: "Personaje",
                columns: new[] { "ActorId", "PeliculaId" });

            migrationBuilder.InsertData(
                table: "Comentario",
                columns: new[] { "Id", "Contenido", "PeliculaId", "Recomendar" },
                values: new object[,]
                {
                    { 2, "Muy buena!!!", 2, true },
                    { 3, "Dura dura", 2, true },
                    { 4, "no debieron hacer eso...", 3, false }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 5, "Ciencia Ficcion" },
                    { 6, "Animacion" }
                });

            migrationBuilder.InsertData(
                table: "Personaje",
                columns: new[] { "ActorId", "PeliculaId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 2, 2, "Nick Fury", 2 },
                    { 2, 3, "Nick Fury", 1 },
                    { 3, 2, "Iron Man", 1 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_PeliculaId",
                table: "Personaje",
                column: "PeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Personaje",
                table: "Personaje");

            migrationBuilder.DropIndex(
                name: "IX_Personaje_PeliculaId",
                table: "Personaje");

            migrationBuilder.DeleteData(
                table: "Comentario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comentario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comentario",
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
                table: "Personaje",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Personaje",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Personaje",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personaje",
                table: "Personaje",
                columns: new[] { "PeliculaId", "ActorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_ActorId",
                table: "Personaje",
                column: "ActorId");
        }
    }
}
