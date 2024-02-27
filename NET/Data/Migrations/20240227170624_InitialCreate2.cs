using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Butacas_Obras_ObraId",
                table: "Butacas");

            migrationBuilder.DropIndex(
                name: "IX_Butacas_ObraId",
                table: "Butacas");

            migrationBuilder.DropColumn(
                name: "ObraId",
                table: "Butacas");

            migrationBuilder.DropColumn(
                name: "numButaca",
                table: "Butacas");

            migrationBuilder.CreateTable(
                name: "ButacaObras",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false),
                    ButacaId = table.Column<int>(type: "int", nullable: false),
                    Butaca_obraId = table.Column<int>(type: "int", nullable: false),
                    Libre = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ButacaObras", x => new { x.ObraId, x.ButacaId });
                    table.ForeignKey(
                        name: "FK_ButacaObras_Butacas_ButacaId",
                        column: x => x.ButacaId,
                        principalTable: "Butacas",
                        principalColumn: "ButacaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ButacaObras_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[] { 1, 1, 0, true });

            migrationBuilder.CreateIndex(
                name: "IX_ButacaObras_ButacaId",
                table: "ButacaObras",
                column: "ButacaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ButacaObras");

            migrationBuilder.AddColumn<int>(
                name: "ObraId",
                table: "Butacas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numButaca",
                table: "Butacas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 1,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 2,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 3,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 4,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 5,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 6,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 7,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 8,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 9,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 10,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 11,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 12,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 13,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 14,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 15,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 16,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 17,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 18,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 19,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 20,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 21,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 22,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 23,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 24,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 25,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 26,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 27,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 28,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 29,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 30,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 31,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 32,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 33,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 34,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 35,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 36,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 37,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 38,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 39,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 40,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 41,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 42,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 43,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 44,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 45,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 46,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 47,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 48,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 49,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 50,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 51,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 52,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 53,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 54,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 55,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 56,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 57,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 58,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 59,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 60,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 61,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 62,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 63,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 64,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 65,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 66,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 67,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 68,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 69,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 70,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 71,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 72,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 73,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 74,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 75,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 76,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 77,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 78,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 79,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 80,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 81,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 82,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 83,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 84,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 85,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 86,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 87,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 88,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 89,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 90,
                column: "ObraId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 91,
                column: "ObraId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Butacas_ObraId",
                table: "Butacas",
                column: "ObraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Butacas_Obras_ObraId",
                table: "Butacas",
                column: "ObraId",
                principalTable: "Obras",
                principalColumn: "ObraId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
