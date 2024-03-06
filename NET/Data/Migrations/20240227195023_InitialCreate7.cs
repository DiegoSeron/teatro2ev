using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Butacas",
                columns: new[] { "ButacaId", "Libre" },
                values: new object[,]
                {
                    { 92, true },
                    { 93, true },
                    { 94, true },
                    { 95, true },
                    { 96, true },
                    { 97, true },
                    { 98, true },
                    { 99, true },
                    { 100, true }
                });

            migrationBuilder.InsertData(
                table: "ButacaObras",
                columns: new[] { "ButacaId", "ObraId", "Butaca_obraId", "Libre" },
                values: new object[,]
                {
                    { 92, 1, 0, true },
                    { 93, 1, 0, true },
                    { 94, 1, 0, true },
                    { 95, 1, 0, true },
                    { 96, 1, 0, true },
                    { 97, 1, 0, true },
                    { 98, 1, 0, true },
                    { 99, 1, 0, true },
                    { 100, 1, 0, true },
                    { 92, 2, 0, true },
                    { 93, 2, 0, true },
                    { 94, 2, 0, true },
                    { 95, 2, 0, true },
                    { 96, 2, 0, true },
                    { 97, 2, 0, true },
                    { 98, 2, 0, true },
                    { 99, 2, 0, true },
                    { 100, 2, 0, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 99, 2 });

            migrationBuilder.DeleteData(
                table: "ButacaObras",
                keyColumns: new[] { "ButacaId", "ObraId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Butacas",
                keyColumn: "ButacaId",
                keyValue: 100);
        }
    }
}
