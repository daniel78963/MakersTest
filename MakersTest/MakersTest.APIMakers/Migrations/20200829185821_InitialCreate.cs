using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakersTest.APIMakers.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editorials",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorials", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    IdLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(maxLength: 100, nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    PrecioSugerido = table.Column<decimal>(nullable: false),
                    Autor = table.Column<string>(nullable: true),
                    EditorialIdEditorial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libros_Editorials_EditorialIdEditorial",
                        column: x => x.EditorialIdEditorial,
                        principalTable: "Editorials",
                        principalColumn: "IdEditorial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_EditorialIdEditorial",
                table: "Libros",
                column: "EditorialIdEditorial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Editorials");
        }
    }
}
