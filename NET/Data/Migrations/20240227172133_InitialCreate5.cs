using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 1, 2, 0, true },
                    { 2, 2, 0, true },
                    { 3, 2, 0, true },
                    { 4, 2, 0, true },
                    { 5, 2, 0, true },
                    { 6, 2, 0, true },
                    { 7, 2, 0, true },
                    { 8, 2, 0, true },
                    { 9, 2, 0, true },
                    { 10, 2, 0, true },
                    { 11, 2, 0, true },
                    { 12, 2, 0, true },
                    { 13, 2, 0, true },
                    { 14, 2, 0, true },
                    { 15, 2, 0, true },
                    { 16, 2, 0, true },
                    { 17, 2, 0, true },
                    { 18, 2, 0, true },
                    { 19, 2, 0, true },
                    { 20, 2, 0, true },
                    { 21, 2, 0, true },
                    { 22, 2, 0, true },
                    { 23, 2, 0, true },
                    { 24, 2, 0, true },
                    { 25, 2, 0, true },
                    { 26, 2, 0, true },
                    { 27, 2, 0, true },
                    { 28, 2, 0, true },
                    { 29, 2, 0, true },
                    { 30, 2, 0, true },
                    { 31, 2, 0, true },
                    { 32, 2, 0, true },
                    { 33, 2, 0, true },
                    { 34, 2, 0, true },
                    { 35, 2, 0, true },
                    { 36, 2, 0, true },
                    { 37, 2, 0, true },
                    { 38, 2, 0, true },
                    { 39, 2, 0, true },
                    { 40, 2, 0, true },
                    { 41, 2, 0, true },
                    { 42, 2, 0, true }
                });

            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 43, 2, 0, true },
                    { 44, 2, 0, true },
                    { 45, 2, 0, true },
                    { 46, 2, 0, true },
                    { 47, 2, 0, true },
                    { 48, 2, 0, true },
                    { 49, 2, 0, true },
                    { 50, 2, 0, true },
                    { 51, 2, 0, true },
                    { 52, 2, 0, true },
                    { 53, 2, 0, true },
                    { 54, 2, 0, true },
                    { 55, 2, 0, true },
                    { 56, 2, 0, true },
                    { 57, 2, 0, true },
                    { 58, 2, 0, true },
                    { 59, 2, 0, true },
                    { 60, 2, 0, true },
                    { 61, 2, 0, true },
                    { 62, 2, 0, true },
                    { 63, 2, 0, true },
                    { 64, 2, 0, true },
                    { 65, 2, 0, true },
                    { 66, 2, 0, true },
                    { 67, 2, 0, true },
                    { 68, 2, 0, true },
                    { 69, 2, 0, true },
                    { 70, 2, 0, true },
                    { 71, 2, 0, true },
                    { 72, 2, 0, true },
                    { 73, 2, 0, true },
                    { 74, 2, 0, true },
                    { 75, 2, 0, true },
                    { 76, 2, 0, true },
                    { 77, 2, 0, true },
                    { 78, 2, 0, true },
                    { 79, 2, 0, true },
                    { 80, 2, 0, true },
                    { 81, 2, 0, true },
                    { 82, 2, 0, true },
                    { 83, 2, 0, true },
                    { 84, 2, 0, true }
                });

            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 85, 2, 0, true },
                    { 86, 2, 0, true },
                    { 87, 2, 0, true },
                    { 88, 2, 0, true },
                    { 89, 2, 0, true },
                    { 90, 2, 0, true },
                    { 91, 2, 0, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 44, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 65, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 91, 2 });
        }
    }
}
