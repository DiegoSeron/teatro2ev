using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Butaca_obraId",
                table: "ButacaObras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Butaca_obraId",
                table: "ButacaObras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
