using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 2, 1, 0, true },
                    { 3, 1, 0, true },
                    { 4, 1, 0, true },
                    { 5, 1, 0, true },
                    { 6, 1, 0, true },
                    { 7, 1, 0, true },
                    { 8, 1, 0, true },
                    { 9, 1, 0, true },
                    { 10, 1, 0, true },
                    { 11, 1, 0, true },
                    { 12, 1, 0, true },
                    { 13, 1, 0, true },
                    { 14, 1, 0, true },
                    { 15, 1, 0, true },
                    { 16, 1, 0, true },
                    { 17, 1, 0, true },
                    { 18, 1, 0, true },
                    { 19, 1, 0, true },
                    { 20, 1, 0, true },
                    { 21, 1, 0, true },
                    { 22, 1, 0, true },
                    { 23, 1, 0, true },
                    { 24, 1, 0, true },
                    { 25, 1, 0, true },
                    { 26, 1, 0, true },
                    { 27, 1, 0, true },
                    { 28, 1, 0, true },
                    { 29, 1, 0, true },
                    { 30, 1, 0, true },
                    { 31, 1, 0, true },
                    { 32, 1, 0, true },
                    { 33, 1, 0, true },
                    { 34, 1, 0, true },
                    { 35, 1, 0, true },
                    { 36, 1, 0, true },
                    { 37, 1, 0, true },
                    { 38, 1, 0, true },
                    { 39, 1, 0, true },
                    { 40, 1, 0, true },
                    { 41, 1, 0, true },
                    { 42, 1, 0, true },
                    { 43, 1, 0, true }
                });

            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 44, 1, 0, true },
                    { 45, 1, 0, true },
                    { 46, 1, 0, true },
                    { 47, 1, 0, true },
                    { 48, 1, 0, true },
                    { 49, 1, 0, true },
                    { 50, 1, 0, true },
                    { 51, 1, 0, true },
                    { 52, 1, 0, true },
                    { 53, 1, 0, true },
                    { 54, 1, 0, true },
                    { 55, 1, 0, true },
                    { 56, 1, 0, true },
                    { 57, 1, 0, true },
                    { 58, 1, 0, true },
                    { 59, 1, 0, true },
                    { 60, 1, 0, true },
                    { 61, 1, 0, true },
                    { 62, 1, 0, true },
                    { 63, 1, 0, true },
                    { 64, 1, 0, true },
                    { 65, 1, 0, true },
                    { 66, 1, 0, true },
                    { 67, 1, 0, true },
                    { 68, 1, 0, true },
                    { 69, 1, 0, true },
                    { 70, 1, 0, true },
                    { 71, 1, 0, true },
                    { 72, 1, 0, true },
                    { 73, 1, 0, true },
                    { 74, 1, 0, true },
                    { 75, 1, 0, true },
                    { 76, 1, 0, true },
                    { 77, 1, 0, true },
                    { 78, 1, 0, true },
                    { 79, 1, 0, true },
                    { 80, 1, 0, true },
                    { 81, 1, 0, true },
                    { 82, 1, 0, true },
                    { 83, 1, 0, true },
                    { 84, 1, 0, true },
                    { 85, 1, 0, true }
                });

            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 86, 1, 0, true },
                    { 87, 1, 0, true },
                    { 88, 1, 0, true },
                    { 89, 1, 0, true },
                    { 90, 1, 0, true },
                    { 91, 1, 0, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 91, 1 });
        }
    }
}
