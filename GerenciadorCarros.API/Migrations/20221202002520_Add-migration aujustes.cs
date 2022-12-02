using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorCarros.API.Migrations
{
    public partial class Addmigrationaujustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Preco",
                table: "Carros",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "string");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Preco",
                table: "Carros",
                type: "string",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }
    }
}
