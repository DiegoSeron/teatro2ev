using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Libre",
                table: "Butacas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Libre",
                table: "Butacas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 1,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 2,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 3,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 4,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 5,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 6,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 7,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 8,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 9,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 10,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 11,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 12,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 13,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 14,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 15,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 16,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 17,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 18,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 19,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 20,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 21,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 22,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 23,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 24,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 25,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 26,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 27,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 28,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 29,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 30,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 31,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 32,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 33,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 34,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 35,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 36,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 37,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 38,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 39,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 40,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 41,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 42,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 43,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 44,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 45,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 46,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 47,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 48,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 49,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 50,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 51,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 52,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 53,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 54,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 55,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 56,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 57,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 58,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 59,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 60,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 61,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 62,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 63,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 64,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 65,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 66,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 67,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 68,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 69,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 70,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 71,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 72,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 73,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 74,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 75,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 76,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 77,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 78,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 79,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 80,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 81,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 82,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 83,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 84,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 85,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 86,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 87,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 88,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 89,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 90,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 91,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 92,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 93,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 94,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 95,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 96,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 97,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 98,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 99,
                column: "Libre",
                value: true);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 100,
                column: "Libre",
                value: true);
        }
    }
}
