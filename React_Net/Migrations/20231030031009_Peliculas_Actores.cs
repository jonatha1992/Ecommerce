using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace React_Net.Migrations
{
    /// <inheritdoc />
    public partial class Peliculas_Actores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genero_Pelicula_PeliculaId",
                table: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Genero_PeliculaId",
                table: "Genero");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Genero");

            migrationBuilder.CreateTable(
                name: "GeneroPelicula",
                columns: table => new
                {
                    GenerosId = table.Column<int>(type: "int", nullable: false),
                    PeliculasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroPelicula", x => new { x.GenerosId, x.PeliculasId });
                    table.ForeignKey(
                        name: "FK_GeneroPelicula_Genero_GenerosId",
                        column: x => x.GenerosId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroPelicula_Pelicula_PeliculasId",
                        column: x => x.PeliculasId,
                        principalTable: "Pelicula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneroPelicula_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneroPelicula");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Genero",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 5,
                column: "PeliculaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 6,
                column: "PeliculaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Genero_PeliculaId",
                table: "Genero",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genero_Pelicula_PeliculaId",
                table: "Genero",
                column: "PeliculaId",
                principalTable: "Pelicula",
                principalColumn: "Id");
        }
    }
}
