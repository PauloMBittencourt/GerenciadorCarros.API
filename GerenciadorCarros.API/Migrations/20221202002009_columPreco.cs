using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorCarros.API.Migrations
{
    public partial class columPreco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Preco",
                table: "Carros",
                type: "varchar(50)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Carros");
        }
    }
}
