using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "DiaObra",
                value: new DateTime(2024, 3, 27, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "DiaObra",
                value: new DateTime(2024, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "DiaObra",
                value: new DateTime(2024, 3, 31, 20, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "DiaObra",
                value: new DateTime(2024, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "DiaObra",
                value: new DateTime(2024, 4, 5, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "DiaObra",
                value: new DateTime(2024, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "DiaObra",
                value: new DateTime(2024, 4, 12, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "DiaObra",
                value: new DateTime(2024, 4, 15, 18, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "DiaObra",
                value: new DateTime(2024, 4, 16, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 11,
                column: "DiaObra",
                value: new DateTime(2024, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "DiaObra",
                value: new DateTime(2024, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "DiaObra",
                value: new DateTime(2024, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "DiaObra",
                value: new DateTime(2024, 2, 7, 20, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "DiaObra",
                value: new DateTime(2024, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "DiaObra",
                value: new DateTime(2024, 2, 29, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "DiaObra",
                value: new DateTime(2024, 3, 3, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "DiaObra",
                value: new DateTime(2024, 3, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "DiaObra",
                value: new DateTime(2024, 4, 4, 18, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "DiaObra",
                value: new DateTime(2024, 4, 10, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 11,
                column: "DiaObra",
                value: new DateTime(2024, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
