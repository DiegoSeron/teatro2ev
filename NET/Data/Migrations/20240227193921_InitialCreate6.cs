using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "La obra 'Don Juan' es un clásico atemporal que explora las travesuras y el encanto del legendario seductor Don Juan. Esta pieza teatral icónica examina la naturaleza humana, el deseo, la moralidad y las consecuencias de nuestras acciones. A través de un cautivador relato, la historia sigue a Don Juan, un personaje carismático y seductor que desafía las normas sociales. Su irresistible magnetismo lo lleva a interactuar con una variedad de personajes, cada uno reflejando diferentes aspectos de la sociedad y la moralidad de la época. 'Don Juan' invita a reflexionar sobre la dualidad del ser humano, la moralidad, el amor y la libertad, envuelto en una trama llena de intriga y emociones intensas.", new DateTime(2024, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "'La Celestina' es una obra maestra de la literatura española escrita por Fernando de Rojas en el siglo XV. Esta tragicomedia narra la historia de amor entre Calisto y Melibea, en un contexto lleno de engaños, pasiones y traiciones. La trama se centra en la intervención de la alcahueta Celestina, una mujer astuta y manipuladora que actúa como intermediaria en el romance. A medida que avanza la historia, se entrelazan intrigas que revelan las complejidades de las relaciones humanas y critican la sociedad de la época. 'La Celestina' es reconocida por su profundidad psicológica en la construcción de personajes y su aguda crítica social, explorando temas como el amor, la codicia, el poder y la moralidad en un estilo literario cautivador.", new DateTime(2024, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "Doble o nada es un thriller emocional ambientado en el hostil ambiente de las altas esferas empresariales. Una historia sobre el amor platónico, traición y engaño, y sobre todo, el poder y la ambición. Este emocionante thriller te mantendrá en vilo hasta el último minuto.", new DateTime(2024, 2, 7, 20, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "Gloria y Josete se acaban de independizar bajo la tutela de Claudia. Ante la necesidad de encontrar un trabajo para poder tener un sueldo con el que mantenerse, Claudia les propone que intenten dedicarse a algo que les guste de verdad. Ellos quieren ser artistas. Para ello deberían encontrar un representante. Esta comedia hilarante sigue las aventuras de este trío en su búsqueda por la fama y la risa del público.", new DateTime(2024, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "El Mago Pop es el nombre artístico de Antonio Díaz, un ilusionista español reconocido por sus impresionantes trucos de magia y espectáculos de ilusionismo. Conocido por combinar magia, tecnología y narrativa en sus actuaciones, El Mago Pop ha cautivado al público con sus shows innovadores y sorprendentes. Sus espectáculos suelen incorporar efectos visuales impactantes, interacción con el público y asombrosas ilusiones que desafían la lógica y la percepción. Antonio Díaz, como El Mago Pop, ha logrado llevar la magia a un nivel moderno y cautivador, convirtiéndose en uno de los ilusionistas más reconocidos a nivel internacional.", new DateTime(2024, 2, 29, 17, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "El Rey León es un espectacular musical inspirado en la película de Disney que ha cautivado a audiencias de todo el mundo. Con música de Elton John y letras de Tim Rice, esta producción teatral transporta al público a la majestuosa sabana africana. La historia sigue el viaje de Simba, un joven león destinado a convertirse en rey, a través de sus aventuras, desafíos y el aprendizaje de valiosas lecciones sobre el honor, el coraje y el amor. El espectáculo se destaca por su impresionante puesta en escena, coloridos vestuarios, efectos visuales deslumbrantes y coreografías espectaculares. 'El Rey León' es una experiencia teatral emocionante y conmovedora, que combina la magia del cine con la energía y la emoción del teatro en vivo.", new DateTime(2024, 3, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "Fango es una obra teatral que aborda temas complejos y profundos relacionados con la condición humana, la lucha interna, la redención y las relaciones interpersonales. Esta obra se sumerge en la complejidad de los personajes y sus conflictos, explorando la naturaleza humana a través de diálogos intensos y situaciones emocionales. A menudo, Fango presenta una reflexión sobre la sociedad y sus injusticias, mostrando la lucha de los individuos por encontrar significado y redención en un mundo lleno de desafíos y adversidades.", new DateTime(2024, 3, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "La función que sale mal es una obra teatral cómica que gira en torno a un grupo de actores aficionados que intentan representar una obra de teatro, pero todo lo que puede salir mal ¡sale mal! La trama se desarrolla con una sucesión de desastres cómicos, desde problemas técnicos hasta errores de actuación y malentendidos entre los personajes. La obra es una comedia llena de situaciones hilarantes y caóticas que mantienen al público riendo a carcajadas. 'La función que sale mal' es conocida por su humor físico, su ingenio y su capacidad para convertir los errores en momentos divertidos e inolvidables para el público.", new DateTime(2024, 3, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "Ilusionate es una emocionante obra de teatro que fusiona el ilusionismo, la magia y el drama en una experiencia teatral única. Esta obra cautivadora transporta al público a un mundo de sorpresas, ilusiones y emociones. Con un elenco talentoso y efectos visuales impactantes, Ilusionate combina la magia del teatro con increíbles trucos y narrativas que mantienen al espectador absorto en un viaje lleno de misterio y asombro. Esta obra teatral es una oportunidad para sumergirse en un universo de ilusiones y disfrutar de un espectáculo que desafía la imaginación y la percepción.", new DateTime(2024, 4, 4, 18, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "José el Soñador es una historia bíblica que relata la vida de José, hijo de Jacob, vendido como esclavo por sus hermanos. La historia sigue la vida de José desde su juventud hasta convertirse en un importante funcionario en Egipto. Conocida por su narrativa llena de intriga, traición y redención, la historia muestra la habilidad de José para interpretar sueños, lo que lo lleva a ganar el favor del faraón y a desempeñar un papel crucial en la historia de Egipto. 'José el Soñador' es un relato emocionante que explora temas de fe, perseverancia y perdón, y ha sido una fuente de inspiración para muchas personas a lo largo de los siglos.", new DateTime(2024, 4, 10, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 11,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "Laponia es una región situada en el norte de Europa que abarca partes de Noruega, Suecia, Finlandia y Rusia. Conocida por su belleza natural y su paisaje ártico, Laponia es famosa por ser el hogar de la gente sami, su cultura única y las auroras boreales que se pueden observar durante la temporada de invierno. Esta región ofrece una amplia gama de actividades, como safaris en trineo de perros, excursiones para avistar renos, esquí, senderismo y la oportunidad de experimentar la cultura sami a través de sus tradiciones, como la artesanía, la música y la gastronomía local. Laponia es un destino popular para aquellos que buscan aventuras inolvidables en un entorno natural espectacular.", new DateTime(2024, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 12,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "Las Mil y Una Noches es una colección de cuentos y fábulas de origen árabe que se remonta a varios siglos. La historia principal sigue a Scheherezade, quien cuenta historias al rey Shahriar para evitar su ejecución. Estas historias incluyen relatos mágicos, aventuras, fábulas morales y cuentos populares que abarcan un amplio espectro de géneros y temas. Entre los cuentos más conocidos se encuentran 'Aladino y la lámpara maravillosa', 'Simbad el marino' y 'Ali Baba y los cuarenta ladrones'. 'Las Mil y Una Noches' ha cautivado a lectores durante generaciones con su riqueza narrativa, su imaginación desbordante y su habilidad para entrelazar historias encantadoras y emocionantes.", new DateTime(2024, 5, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 11,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 12,
                columns: new[] { "Descripcion", "DiaObra" },
                values: new object[] { "false", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
