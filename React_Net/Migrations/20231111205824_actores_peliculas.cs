using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace React_Net.Migrations
{
    /// <inheritdoc />
    public partial class actores_peliculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "FechaNacimiento", "Fortuna", "Nombre" },
                values: new object[,]
                {
                    { 2, new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "Samuel L. Jackson" },
                    { 3, new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000m, "Robert Downey Jr." }
                });

            migrationBuilder.InsertData(
                table: "Pelicula",
                columns: new[] { "Id", "EnCines", "FechaEstreno", "Titulo" },
                values: new object[,]
                {
                    { 2, false, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers Endgame" },
                    { 3, false, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: No Way Home" },
                    { 4, false, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: Across the Spider-Verse (Part One)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
