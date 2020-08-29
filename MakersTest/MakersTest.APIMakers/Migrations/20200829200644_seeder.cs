using Microsoft.EntityFrameworkCore.Migrations;

namespace MakersTest.APIMakers.Migrations
{
    public partial class seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Editorials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Nombre",
                table: "Editorials",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
