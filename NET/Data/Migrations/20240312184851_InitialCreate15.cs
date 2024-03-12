using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObraRepartos");

            migrationBuilder.DropTable(
                name: "Repartos");

            migrationBuilder.AddColumn<string>(
                name: "Reparto",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "Reparto",
                value: "Luisa Fernández,Andrés Sánchez,María Gómez,Javier Rodríguez,Elena Pérez,Carlos Martínez,Ana Ruiz,Pedro Vázquez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "Reparto",
                value: "Sofía Martínez, Diego López, Lucía García, Javier Rodríguez, Elena Pérez, Carlos Gómez, Ana Ruiz, Pedro Vázquez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "Reparto",
                value: "Laura Martínez,Diego López,Ana Fernández,Javier Gómez,Sofía Rodríguez,Andrés Pérez,Elena Ruiz,Carlos Martín");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "Reparto",
                value: "María García,Javier Martínez,Lucía Rodríguez,Andrés López,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "Reparto",
                value: "Javier Martínez, Lucía García, Andrés Fernández, María López, Carlos Ruiz, Elena Sánchez, Pedro González, Ana Martín");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "Reparto",
                value: "Sofía Martínez,Diego López,Lucía García,Javier Rodríguez,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "Reparto",
                value: "Sara Pérez,Javier García,Lucía Martínez,Andrés López,Elena Rodríguez,Carlos Fernández,María Gómez,Pedro Ruiz");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "Reparto",
                value: "Sofía Martínez, Diego López, Lucía García, Javier Rodríguez, Elena Pérez, Carlos Gómez, Ana Ruiz, Pedro Vázquez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "Reparto",
                value: "Sofía Martínez,Diego López,Lucía García,Javier Rodríguez,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "Reparto",
                value: "Ana García,Luis Martínez,María Fernández,Javier Rodríguez,Elena Pérez,Carlos Sánchez,Lucía Martín,Andrés Gómez");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 11,
                column: "Reparto",
                value: "Erik Larsson, Ingrid Johansson,Sven Andersson,Hanna Bergman,Frida Nilsson,Oskar Magnusson,Emma Karlsson,Viktor Lindström");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 12,
                column: "Reparto",
                value: "Leyla Khan,Amir Shah,Jamil Ahmed,Nadia Malik,Karim Hassan,Ayesha Khan,Rashid Ali,Yasir Mahmood");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reparto",
                table: "Obras");

            migrationBuilder.CreateTable(
                name: "Repartos",
                columns: table => new
                {
                    RepartoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repartos", x => x.RepartoId);
                });

            migrationBuilder.CreateTable(
                name: "ObraRepartos",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false),
                    RepartoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObraRepartos", x => new { x.ObraId, x.RepartoId });
                    table.ForeignKey(
                        name: "FK_ObraRepartos_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObraRepartos_Repartos_RepartoId",
                        column: x => x.RepartoId,
                        principalTable: "Repartos",
                        principalColumn: "RepartoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] { "RepartoId", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 1, "Luisa Fernández", "Doña Ana" },
                    { 2, "Andrés Sánchez", "Don Juan" },
                    { 3, "María Gómez", "Doña Inés" },
                    { 4, "Javier Rodríguez", "Don Luis" },
                    { 5, "Elena Pérez", "Doña Elvira" },
                    { 6, "Carlos Martínez", "Molière" },
                    { 7, "Ana Ruiz", "Sganarelle" },
                    { 8, "Pedro Vázquez", "Don Gonzalo" },
                    { 9, "Sofía Martínez", "Celestina" },
                    { 10, "Diego López", "Calisto" },
                    { 11, "Lucía García", "Melibea" },
                    { 12, "Javier Rodríguez", "Sempronio" },
                    { 13, "Elena Pérez", "Elicia" },
                    { 14, "Carlos Gómez", "Tristán" },
                    { 15, "Ana Ruiz", "Pármeno" },
                    { 16, "Pedro Vázquez", "Alisa" },
                    { 17, "Luis García", "Chris" },
                    { 18, "María López", "Annie" },
                    { 19, "Andrés Martínez", "Jonathan" },
                    { 20, "Elena Rodríguez", "Sandra" },
                    { 21, "Carlos Ruiz", "Max" },
                    { 22, "Lucía González", "Dennis" },
                    { 23, "Javier Fernández", "Trevor" },
                    { 24, "Ana Pérez", "Robert" },
                    { 25, "Erik Larsson", "Olaf, guía sami" },
                    { 26, "Ingrid Johansson", "Kaisa, chamán sami" },
                    { 27, "Sven Andersson", "Bjorn, explorador" },
                    { 28, "Hanna Bergman", "Lena, viajera aventurera" },
                    { 29, "Frida Nilsson", "Elsa, niña sami" },
                    { 30, "Oskar Magnusson", "Gunnar, habitante local" },
                    { 31, "Emma Karlsson", "Sofia, fotógrafa" },
                    { 32, "Viktor Lindström", "Ole, cazador" },
                    { 33, "Ana García", "José" },
                    { 34, "Luis Martínez", "Jacob" },
                    { 35, "María Fernández", "Rebeca" },
                    { 36, "Javier Rodríguez", "Faraón" },
                    { 37, "Elena Pérez", "Esposa de Potifar" },
                    { 38, "Carlos Sánchez", "Potifar" },
                    { 39, "Lucía Martín", "Mayordomo" },
                    { 40, "Andrés Gómez", "Elvisar" },
                    { 41, "Javier Martínez", "El Mago Pop (Antonio Díaz)" },
                    { 42, "Lucía García", "Asistente del Mago" }
                });

            migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] { "RepartoId", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 43, "Andrés Fernández", "Participante del Público" },
                    { 44, "María López", "Asistente Técnico" },
                    { 45, "Carlos Ruiz", "Encargado de Escenario" },
                    { 46, "Elena Sánchez", "Coordinador de Efectos Especiales" },
                    { 47, "Pedro González", "Diseñador de Iluminación" },
                    { 48, "Ana Martín", "Gerente de Producción" },
                    { 49, "Sofía Martínez", "Lena, la ilusionista" },
                    { 50, "Diego López", "David, el aprendiz de mago" },
                    { 51, "Lucía García", "María, la asistente" },
                    { 52, "Javier Rodríguez", "Carlos, el escéptico" },
                    { 53, "Elena Pérez", "Laura, la espectadora" },
                    { 54, "Carlos Gómez", "Jorge, el incrédulo" },
                    { 55, "Ana Ruiz", "Paula, la admiradora" },
                    { 56, "Pedro Vázquez", "Pablo, el curioso" },
                    { 57, "Leyla Khan", "Scheherezade" },
                    { 58, "Amir Shah", "Sultán Shahriar" },
                    { 59, "Jamil Ahmed", "Aladino" },
                    { 60, "Nadia Malik", "Jasmine" },
                    { 61, "Karim Hassan", "Simbad" },
                    { 62, "Ayesha Khan", "Scheherezade (joven)" },
                    { 63, "Rashid Ali", "Ali Baba" },
                    { 64, "Yasir Mahmood", "Genio" },
                    { 65, "Sofía Martínez", "Nala" },
                    { 66, "Diego López", "Simba" },
                    { 67, "Lucía García", "Sarabi" },
                    { 68, "Javier Rodríguez", "Mufasa" },
                    { 69, "Elena Pérez", "Rafiki" },
                    { 70, "Carlos Gómez", "Scar" },
                    { 71, "Ana Ruiz", "Timón" },
                    { 72, "Pedro Vázquez", "Pumbaa" },
                    { 73, "María García", "Lola" },
                    { 74, "Javier Martínez", "Pedro" },
                    { 75, "Lucía Rodríguez", "Ana" },
                    { 76, "Andrés López", "Juan" },
                    { 77, "Elena Pérez", "Laura" },
                    { 78, "Carlos Gómez", "Pablo" },
                    { 79, "Ana Ruiz", "Carmen" },
                    { 80, "Pedro Vázquez", "Luis" },
                    { 81, "Sara Pérez", "Laura" },
                    { 82, "Javier García", "Carlos" },
                    { 83, "Lucía Martínez", "Ana" },
                    { 84, "Andrés López", "Diego" }
                });

            migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] { "RepartoId", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 85, "Elena Rodríguez", "María" },
                    { 86, "Carlos Fernández", "Javier" },
                    { 87, "María Gómez", "Sofía" },
                    { 88, "Pedro Ruiz", "Pablo" },
                    { 89, "Laura Martínez", "Marina" },
                    { 90, "Diego López", "Carlos" },
                    { 91, "Ana Fernández", "Sandra" },
                    { 92, "Javier Gómez", "Mario" },
                    { 93, "Sofía Rodríguez", "Laura" },
                    { 94, "Andrés Pérez", "Pedro" },
                    { 95, "Elena Ruiz", "Lorena" },
                    { 96, "Carlos Martín", "Pablo" }
                });

            migrationBuilder.InsertData(
                table: "ObraRepartos",
                columns: new[] { "ObraId", "RepartoId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 },
                    { 3, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 4, 25 },
                    { 4, 26 },
                    { 4, 27 },
                    { 4, 28 },
                    { 4, 29 },
                    { 4, 30 },
                    { 4, 31 },
                    { 4, 32 },
                    { 5, 33 },
                    { 5, 34 },
                    { 5, 35 },
                    { 5, 36 },
                    { 5, 37 },
                    { 5, 38 },
                    { 5, 39 },
                    { 5, 40 },
                    { 6, 41 },
                    { 6, 42 }
                });

            migrationBuilder.InsertData(
                table: "ObraRepartos",
                columns: new[] { "ObraId", "RepartoId" },
                values: new object[,]
                {
                    { 6, 43 },
                    { 6, 44 },
                    { 6, 45 },
                    { 6, 46 },
                    { 6, 47 },
                    { 6, 48 },
                    { 7, 49 },
                    { 7, 50 },
                    { 7, 51 },
                    { 7, 52 },
                    { 7, 53 },
                    { 7, 54 },
                    { 7, 55 },
                    { 7, 56 },
                    { 8, 57 },
                    { 8, 58 },
                    { 8, 59 },
                    { 8, 60 },
                    { 8, 61 },
                    { 8, 62 },
                    { 8, 63 },
                    { 8, 64 },
                    { 9, 65 },
                    { 9, 66 },
                    { 9, 67 },
                    { 9, 68 },
                    { 9, 69 },
                    { 9, 70 },
                    { 9, 71 },
                    { 9, 72 },
                    { 10, 73 },
                    { 10, 74 },
                    { 10, 75 },
                    { 10, 76 },
                    { 10, 77 },
                    { 10, 78 },
                    { 10, 79 },
                    { 10, 80 },
                    { 11, 81 },
                    { 11, 82 },
                    { 11, 83 },
                    { 11, 84 }
                });

            migrationBuilder.InsertData(
                table: "ObraRepartos",
                columns: new[] { "ObraId", "RepartoId" },
                values: new object[,]
                {
                    { 11, 85 },
                    { 11, 86 },
                    { 11, 87 },
                    { 11, 88 },
                    { 12, 89 },
                    { 12, 90 },
                    { 12, 91 },
                    { 12, 92 },
                    { 12, 93 },
                    { 12, 94 },
                    { 12, 95 },
                    { 12, 96 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObraRepartos_RepartoId",
                table: "ObraRepartos",
                column: "RepartoId");
        }
    }
}
