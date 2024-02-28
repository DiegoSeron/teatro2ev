using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tickett.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Tickett.Data
{
    public class ObraContext : DbContext
    {
        public ObraContext(DbContextOptions<ObraContext> options)
            : base(options)
        {

        }
        
        public List<ButacaObra> CrearButacasObra(int obraId)
        {
            List<ButacaObra> butacas = new List<ButacaObra>();
            for (int i = 1; i <= 100; i++)
            {
                butacas.Add(new ButacaObra
                {
                    ButacaId = i,
                    ObraId = obraId,
                    Libre = true,
                });
            }

            return butacas;

        }
        public List<Butaca> CrearButacas()
        {
            List<Butaca> butacas = new List<Butaca>();

            for (int i = 1; i <= 100; i++)
            {
                butacas.Add(new Butaca
                {
                    ButacaId = i,
                });
            }

            return butacas;

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<ObraReparto>()
                .HasKey(o => new { o.ObraId, o.RepartoId });

            modelBuilder.Entity<ObraReparto>()
                .HasOne(o => o.Obra)
                .WithMany(p => p.ListaObraReparto)
                .HasForeignKey(pi => pi.ObraId);

            modelBuilder.Entity<ObraReparto>()
                .HasOne(r => r.Reparto)
                .WithMany(i => i.ListaObraReparto)
                .HasForeignKey(pi => pi.RepartoId);


            modelBuilder.Entity<ButacaObra>()
                .HasKey(o => new { o.ObraId, o.ButacaId });

            modelBuilder.Entity<ButacaObra>()
                .HasOne(o => o.Obra)
                .WithMany(p => p.ListaButacaObra)
                .HasForeignKey(pi => pi.ObraId);

            modelBuilder.Entity<ButacaObra>()
                .HasOne(b => b.Butaca)
                .WithMany(i => i.ListaButacaObra)
                .HasForeignKey(pi => pi.ButacaId);




            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, Titulo = "Don Juan", Descripcion = "La obra 'Don Juan' es un clásico atemporal que explora las travesuras y el encanto del legendario seductor Don Juan. Esta pieza teatral icónica examina la naturaleza humana, el deseo, la moralidad y las consecuencias de nuestras acciones. A través de un cautivador relato, la historia sigue a Don Juan, un personaje carismático y seductor que desafía las normas sociales. Su irresistible magnetismo lo lleva a interactuar con una variedad de personajes, cada uno reflejando diferentes aspectos de la sociedad y la moralidad de la época. 'Don Juan' invita a reflexionar sobre la dualidad del ser humano, la moralidad, el amor y la libertad, envuelto en una trama llena de intriga y emociones intensas.", DiaObra = new DateTime(2024, 01, 13, 13, 0, 0), Imagen = "donjuan.jpg", Genero = "Romance", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 2, Titulo = "Celestina", Descripcion = "'La Celestina' es una obra maestra de la literatura española escrita por Fernando de Rojas en el siglo XV. Esta tragicomedia narra la historia de amor entre Calisto y Melibea, en un contexto lleno de engaños, pasiones y traiciones. La trama se centra en la intervención de la alcahueta Celestina, una mujer astuta y manipuladora que actúa como intermediaria en el romance. A medida que avanza la historia, se entrelazan intrigas que revelan las complejidades de las relaciones humanas y critican la sociedad de la época. 'La Celestina' es reconocida por su profundidad psicológica en la construcción de personajes y su aguda crítica social, explorando temas como el amor, la codicia, el poder y la moralidad en un estilo literario cautivador.", DiaObra = new DateTime(2024, 01, 25, 16, 0, 0), Imagen = "celestina.jpg", Genero = "Romance", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 3, Titulo = "Doble o nada", Descripcion = "Doble o nada es un thriller emocional ambientado en el hostil ambiente de las altas esferas empresariales. Una historia sobre el amor platónico, traición y engaño, y sobre todo, el poder y la ambición. Este emocionante thriller te mantendrá en vilo hasta el último minuto.", DiaObra = new DateTime(2024, 02, 7, 20, 30, 0), Imagen = "doble-o-nada.jpg", Genero = "Thriller", Duracion = 115, Precio = 20 },
                new Obra { ObraId = 4, Titulo = "Campeones", Descripcion = "Gloria y Josete se acaban de independizar bajo la tutela de Claudia. Ante la necesidad de encontrar un trabajo para poder tener un sueldo con el que mantenerse, Claudia les propone que intenten dedicarse a algo que les guste de verdad. Ellos quieren ser artistas. Para ello deberían encontrar un representante. Esta comedia hilarante sigue las aventuras de este trío en su búsqueda por la fama y la risa del público.", DiaObra = new DateTime(2024, 02, 15, 20, 0, 0), Imagen = "campeones.jpg", Genero = "Comedia", Duracion = 140, Precio = 35 },
                new Obra { ObraId = 5, Titulo = "El mago Pop", Descripcion = "El Mago Pop es el nombre artístico de Antonio Díaz, un ilusionista español reconocido por sus impresionantes trucos de magia y espectáculos de ilusionismo. Conocido por combinar magia, tecnología y narrativa en sus actuaciones, El Mago Pop ha cautivado al público con sus shows innovadores y sorprendentes. Sus espectáculos suelen incorporar efectos visuales impactantes, interacción con el público y asombrosas ilusiones que desafían la lógica y la percepción. Antonio Díaz, como El Mago Pop, ha logrado llevar la magia a un nivel moderno y cautivador, convirtiéndose en uno de los ilusionistas más reconocidos a nivel internacional.", DiaObra = new DateTime(2024, 02, 29, 17, 30, 0), Imagen = "el-mago-pop.jpg", Genero = "Monologo", Duracion = 135, Precio = 30 },
                new Obra { ObraId = 6, Titulo = "El Rey Leon", Descripcion = "El Rey León es un espectacular musical inspirado en la película de Disney que ha cautivado a audiencias de todo el mundo. Con música de Elton John y letras de Tim Rice, esta producción teatral transporta al público a la majestuosa sabana africana. La historia sigue el viaje de Simba, un joven león destinado a convertirse en rey, a través de sus aventuras, desafíos y el aprendizaje de valiosas lecciones sobre el honor, el coraje y el amor. El espectáculo se destaca por su impresionante puesta en escena, coloridos vestuarios, efectos visuales deslumbrantes y coreografías espectaculares. 'El Rey León' es una experiencia teatral emocionante y conmovedora, que combina la magia del cine con la energía y la emoción del teatro en vivo.", DiaObra = new DateTime(2024, 03, 03, 19, 0, 0), Imagen = "ElReyLeon3Aniv200.jpg", Genero = "Musical", Duracion = 100, Precio = 10 },
                new Obra { ObraId = 7, Titulo = "Fango", Descripcion = "Fango es una obra teatral que aborda temas complejos y profundos relacionados con la condición humana, la lucha interna, la redención y las relaciones interpersonales. Esta obra se sumerge en la complejidad de los personajes y sus conflictos, explorando la naturaleza humana a través de diálogos intensos y situaciones emocionales. A menudo, Fango presenta una reflexión sobre la sociedad y sus injusticias, mostrando la lucha de los individuos por encontrar significado y redención en un mundo lleno de desafíos y adversidades.", DiaObra = new DateTime(2024, 03, 16, 12, 0, 0), Imagen = "fango.jpg", Genero = "Monologo", Duracion = 90, Precio = 40 },
                new Obra { ObraId = 8, Titulo = "La Funcion que Sale Mal", Descripcion = "La función que sale mal es una obra teatral cómica que gira en torno a un grupo de actores aficionados que intentan representar una obra de teatro, pero todo lo que puede salir mal ¡sale mal! La trama se desarrolla con una sucesión de desastres cómicos, desde problemas técnicos hasta errores de actuación y malentendidos entre los personajes. La obra es una comedia llena de situaciones hilarantes y caóticas que mantienen al público riendo a carcajadas. 'La función que sale mal' es conocida por su humor físico, su ingenio y su capacidad para convertir los errores en momentos divertidos e inolvidables para el público.", DiaObra = new DateTime(2024, 03, 21, 19, 0, 0), Imagen = "funcion-sale.mal.jpg", Genero = "Thriller", Duracion = 110, Precio = 30 },
                new Obra { ObraId = 9, Titulo = "Ilusionate", Descripcion = "Ilusionate es una emocionante obra de teatro que fusiona el ilusionismo, la magia y el drama en una experiencia teatral única. Esta obra cautivadora transporta al público a un mundo de sorpresas, ilusiones y emociones. Con un elenco talentoso y efectos visuales impactantes, Ilusionate combina la magia del teatro con increíbles trucos y narrativas que mantienen al espectador absorto en un viaje lleno de misterio y asombro. Esta obra teatral es una oportunidad para sumergirse en un universo de ilusiones y disfrutar de un espectáculo que desafía la imaginación y la percepción.", DiaObra = new DateTime(2024, 04, 04, 18, 15, 0), Imagen = "ilusionate.jpg", Genero = "Monologo", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 10, Titulo = "Jose el soñador", Descripcion = "José el Soñador es una historia bíblica que relata la vida de José, hijo de Jacob, vendido como esclavo por sus hermanos. La historia sigue la vida de José desde su juventud hasta convertirse en un importante funcionario en Egipto. Conocida por su narrativa llena de intriga, traición y redención, la historia muestra la habilidad de José para interpretar sueños, lo que lo lleva a ganar el favor del faraón y a desempeñar un papel crucial en la historia de Egipto. 'José el Soñador' es un relato emocionante que explora temas de fe, perseverancia y perdón, y ha sido una fuente de inspiración para muchas personas a lo largo de los siglos.", DiaObra = new DateTime(2024, 04, 10, 12, 0, 0), Imagen = "jose-el-sonador.jpg", Genero = "Drama", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 11, Titulo = "Laponia", Descripcion = "Laponia es una región situada en el norte de Europa que abarca partes de Noruega, Suecia, Finlandia y Rusia. Conocida por su belleza natural y su paisaje ártico, Laponia es famosa por ser el hogar de la gente sami, su cultura única y las auroras boreales que se pueden observar durante la temporada de invierno. Esta región ofrece una amplia gama de actividades, como safaris en trineo de perros, excursiones para avistar renos, esquí, senderismo y la oportunidad de experimentar la cultura sami a través de sus tradiciones, como la artesanía, la música y la gastronomía local. Laponia es un destino popular para aquellos que buscan aventuras inolvidables en un entorno natural espectacular.", DiaObra = new DateTime(2024, 04, 23, 16, 0, 0), Imagen = "laponia.jpg", Genero = "Thriller", Duracion = 125, Precio = 20 },
                new Obra { ObraId = 12, Titulo = "Las mil y una noches", Descripcion = "Las Mil y Una Noches es una colección de cuentos y fábulas de origen árabe que se remonta a varios siglos. La historia principal sigue a Scheherezade, quien cuenta historias al rey Shahriar para evitar su ejecución. Estas historias incluyen relatos mágicos, aventuras, fábulas morales y cuentos populares que abarcan un amplio espectro de géneros y temas. Entre los cuentos más conocidos se encuentran 'Aladino y la lámpara maravillosa', 'Simbad el marino' y 'Ali Baba y los cuarenta ladrones'. 'Las Mil y Una Noches' ha cautivado a lectores durante generaciones con su riqueza narrativa, su imaginación desbordante y su habilidad para entrelazar historias encantadoras y emocionantes.", DiaObra = new DateTime(2024, 05, 01, 18, 0, 0), Imagen = "las-mil-y-una-noches.jpg", Genero = "Comedia", Duracion = 30, Precio = 25 }

            );

            modelBuilder.Entity<Reparto>().HasData(
                new Reparto { RepartoId = 1, Nombre = "Luisa Fernández", Rol = "Doña Ana" },
                new Reparto { RepartoId = 2, Nombre = "Andrés Sánchez", Rol = "Don Juan" },
                new Reparto { RepartoId = 3, Nombre = "María Gómez", Rol = "Doña Inés" },
                new Reparto { RepartoId = 4, Nombre = "Javier Rodríguez", Rol = "Don Luis" },
                new Reparto { RepartoId = 5, Nombre = "Elena Pérez", Rol = "Doña Elvira" },
                new Reparto { RepartoId = 6, Nombre = "Carlos Martínez", Rol = "Molière" },
                new Reparto { RepartoId = 7, Nombre = "Ana Ruiz", Rol = "Sganarelle" },
                new Reparto { RepartoId = 8, Nombre = "Pedro Vázquez", Rol = "Don Gonzalo" },
                new Reparto { RepartoId = 9, Nombre = "Sofía Martínez", Rol = "Celestina" },
                new Reparto { RepartoId = 10, Nombre = "Diego López", Rol = "Calisto" },
                new Reparto { RepartoId = 11, Nombre = "Lucía García", Rol = "Melibea" },
                new Reparto { RepartoId = 12, Nombre = "Javier Rodríguez", Rol = "Sempronio" },
                new Reparto { RepartoId = 13, Nombre = "Elena Pérez", Rol = "Elicia" },
                new Reparto { RepartoId = 14, Nombre = "Carlos Gómez", Rol = "Tristán" },
                new Reparto { RepartoId = 15, Nombre = "Ana Ruiz", Rol = "Pármeno" },
                new Reparto { RepartoId = 16, Nombre = "Pedro Vázquez", Rol = "Alisa" },
                new Reparto { RepartoId = 17, Nombre = "Luis García", Rol = "Chris" },
                new Reparto { RepartoId = 18, Nombre = "María López", Rol = "Annie" },
                new Reparto { RepartoId = 19, Nombre = "Andrés Martínez", Rol = "Jonathan" },
                new Reparto { RepartoId = 20, Nombre = "Elena Rodríguez", Rol = "Sandra" },
                new Reparto { RepartoId = 21, Nombre = "Carlos Ruiz", Rol = "Max" },
                new Reparto { RepartoId = 22, Nombre = "Lucía González", Rol = "Dennis" },
                new Reparto { RepartoId = 23, Nombre = "Javier Fernández", Rol = "Trevor" },
                new Reparto { RepartoId = 24, Nombre = "Ana Pérez", Rol = "Robert" },
                new Reparto { RepartoId = 25, Nombre = "Erik Larsson", Rol = "Olaf, guía sami" },
                new Reparto { RepartoId = 26, Nombre = "Ingrid Johansson", Rol = "Kaisa, chamán sami" },
                new Reparto { RepartoId = 27, Nombre = "Sven Andersson", Rol = "Bjorn, explorador" },
                new Reparto { RepartoId = 28, Nombre = "Hanna Bergman", Rol = "Lena, viajera aventurera" },
                new Reparto { RepartoId = 29, Nombre = "Frida Nilsson", Rol = "Elsa, niña sami" },
                new Reparto { RepartoId = 30, Nombre = "Oskar Magnusson", Rol = "Gunnar, habitante local" },
                new Reparto { RepartoId = 31, Nombre = "Emma Karlsson", Rol = "Sofia, fotógrafa" },
                new Reparto { RepartoId = 32, Nombre = "Viktor Lindström", Rol = "Ole, cazador" },
                new Reparto { RepartoId = 33, Nombre = "Ana García", Rol = "José" },
                new Reparto { RepartoId = 34, Nombre = "Luis Martínez", Rol = "Jacob" },
                new Reparto { RepartoId = 35, Nombre = "María Fernández", Rol = "Rebeca" },
                new Reparto { RepartoId = 36, Nombre = "Javier Rodríguez", Rol = "Faraón" },
                new Reparto { RepartoId = 37, Nombre = "Elena Pérez", Rol = "Esposa de Potifar" },
                new Reparto { RepartoId = 38, Nombre = "Carlos Sánchez", Rol = "Potifar" },
                new Reparto { RepartoId = 39, Nombre = "Lucía Martín", Rol = "Mayordomo" },
                new Reparto { RepartoId = 40, Nombre = "Andrés Gómez", Rol = "Elvisar" },
                new Reparto { RepartoId = 41, Nombre = "Javier Martínez", Rol = "El Mago Pop (Antonio Díaz)" },
                new Reparto { RepartoId = 42, Nombre = "Lucía García", Rol = "Asistente del Mago" },
                new Reparto { RepartoId = 43, Nombre = "Andrés Fernández", Rol = "Participante del Público" },
                new Reparto { RepartoId = 44, Nombre = "María López", Rol = "Asistente Técnico" },
                new Reparto { RepartoId = 45, Nombre = "Carlos Ruiz", Rol = "Encargado de Escenario" },
                new Reparto { RepartoId = 46, Nombre = "Elena Sánchez", Rol = "Coordinador de Efectos Especiales" },
                new Reparto { RepartoId = 47, Nombre = "Pedro González", Rol = "Diseñador de Iluminación" },
                new Reparto { RepartoId = 48, Nombre = "Ana Martín", Rol = "Gerente de Producción" },
                new Reparto { RepartoId = 49, Nombre = "Sofía Martínez", Rol = "Lena, la ilusionista" },
                new Reparto { RepartoId = 50, Nombre = "Diego López", Rol = "David, el aprendiz de mago" },
                new Reparto { RepartoId = 51, Nombre = "Lucía García", Rol = "María, la asistente" },
                new Reparto { RepartoId = 52, Nombre = "Javier Rodríguez", Rol = "Carlos, el escéptico" },
                new Reparto { RepartoId = 53, Nombre = "Elena Pérez", Rol = "Laura, la espectadora" },
                new Reparto { RepartoId = 54, Nombre = "Carlos Gómez", Rol = "Jorge, el incrédulo" },
                new Reparto { RepartoId = 55, Nombre = "Ana Ruiz", Rol = "Paula, la admiradora" },
                new Reparto { RepartoId = 56, Nombre = "Pedro Vázquez", Rol = "Pablo, el curioso" },
                new Reparto { RepartoId = 57, Nombre = "Leyla Khan", Rol = "Scheherezade" },
                new Reparto { RepartoId = 58, Nombre = "Amir Shah", Rol = "Sultán Shahriar" },
                new Reparto { RepartoId = 59, Nombre = "Jamil Ahmed", Rol = "Aladino" },
                new Reparto { RepartoId = 60, Nombre = "Nadia Malik", Rol = "Jasmine" },
                new Reparto { RepartoId = 61, Nombre = "Karim Hassan", Rol = "Simbad" },
                new Reparto { RepartoId = 62, Nombre = "Ayesha Khan", Rol = "Scheherezade (joven)" },
                new Reparto { RepartoId = 63, Nombre = "Rashid Ali", Rol = "Ali Baba" },
                new Reparto { RepartoId = 64, Nombre = "Yasir Mahmood", Rol = "Genio" },
                new Reparto { RepartoId = 65, Nombre = "Sofía Martínez", Rol = "Nala" },
                new Reparto { RepartoId = 66, Nombre = "Diego López", Rol = "Simba" },
                new Reparto { RepartoId = 67, Nombre = "Lucía García", Rol = "Sarabi" },
                new Reparto { RepartoId = 68, Nombre = "Javier Rodríguez", Rol = "Mufasa" },
                new Reparto { RepartoId = 69, Nombre = "Elena Pérez", Rol = "Rafiki" },
                new Reparto { RepartoId = 70, Nombre = "Carlos Gómez", Rol = "Scar" },
                new Reparto { RepartoId = 71, Nombre = "Ana Ruiz", Rol = "Timón" },
                new Reparto { RepartoId = 72, Nombre = "Pedro Vázquez", Rol = "Pumbaa" },
                new Reparto { RepartoId = 73, Nombre = "María García", Rol = "Lola" },
                new Reparto { RepartoId = 74, Nombre = "Javier Martínez", Rol = "Pedro" },
                new Reparto { RepartoId = 75, Nombre = "Lucía Rodríguez", Rol = "Ana" },
                new Reparto { RepartoId = 76, Nombre = "Andrés López", Rol = "Juan" },
                new Reparto { RepartoId = 77, Nombre = "Elena Pérez", Rol = "Laura" },
                new Reparto { RepartoId = 78, Nombre = "Carlos Gómez", Rol = "Pablo" },
                new Reparto { RepartoId = 79, Nombre = "Ana Ruiz", Rol = "Carmen" },
                new Reparto { RepartoId = 80, Nombre = "Pedro Vázquez", Rol = "Luis" },
                new Reparto { RepartoId = 81, Nombre = "Sara Pérez", Rol = "Laura" },
                new Reparto { RepartoId = 82, Nombre = "Javier García", Rol = "Carlos" },
                new Reparto { RepartoId = 83, Nombre = "Lucía Martínez", Rol = "Ana" },
                new Reparto { RepartoId = 84, Nombre = "Andrés López", Rol = "Diego" },
                new Reparto { RepartoId = 85, Nombre = "Elena Rodríguez", Rol = "María" },
                new Reparto { RepartoId = 86, Nombre = "Carlos Fernández", Rol = "Javier" },
                new Reparto { RepartoId = 87, Nombre = "María Gómez", Rol = "Sofía" },
                new Reparto { RepartoId = 88, Nombre = "Pedro Ruiz", Rol = "Pablo" },
                new Reparto { RepartoId = 89, Nombre = "Laura Martínez", Rol = "Marina" },
                new Reparto { RepartoId = 90, Nombre = "Diego López", Rol = "Carlos" },
                new Reparto { RepartoId = 91, Nombre = "Ana Fernández", Rol = "Sandra" },
                new Reparto { RepartoId = 92, Nombre = "Javier Gómez", Rol = "Mario" },
                new Reparto { RepartoId = 93, Nombre = "Sofía Rodríguez", Rol = "Laura" },
                new Reparto { RepartoId = 94, Nombre = "Andrés Pérez", Rol = "Pedro" },
                new Reparto { RepartoId = 95, Nombre = "Elena Ruiz", Rol = "Lorena" },
                new Reparto { RepartoId = 96, Nombre = "Carlos Martín", Rol = "Pablo" }
            );
            modelBuilder.Entity<ObraReparto>().HasData(
                new ObraReparto { ObraId = 1, RepartoId = 1 },
                new ObraReparto { ObraId = 1, RepartoId = 2 },
                new ObraReparto { ObraId = 1, RepartoId = 3 },
                new ObraReparto { ObraId = 1, RepartoId = 4 },
                new ObraReparto { ObraId = 1, RepartoId = 5 },
                new ObraReparto { ObraId = 1, RepartoId = 6 },
                new ObraReparto { ObraId = 1, RepartoId = 7 },
                new ObraReparto { ObraId = 1, RepartoId = 8 },
                new ObraReparto { ObraId = 2, RepartoId = 9 },
                new ObraReparto { ObraId = 2, RepartoId = 10 },
                new ObraReparto { ObraId = 2, RepartoId = 11 },
                new ObraReparto { ObraId = 2, RepartoId = 12 },
                new ObraReparto { ObraId = 2, RepartoId = 13 },
                new ObraReparto { ObraId = 2, RepartoId = 14 },
                new ObraReparto { ObraId = 2, RepartoId = 15 },
                new ObraReparto { ObraId = 2, RepartoId = 16 },
                new ObraReparto { ObraId = 3, RepartoId = 17 },
                new ObraReparto { ObraId = 3, RepartoId = 18 },
                new ObraReparto { ObraId = 3, RepartoId = 19 },
                new ObraReparto { ObraId = 3, RepartoId = 20 },
                new ObraReparto { ObraId = 3, RepartoId = 21 },
                new ObraReparto { ObraId = 3, RepartoId = 22 },
                new ObraReparto { ObraId = 3, RepartoId = 23 },
                new ObraReparto { ObraId = 3, RepartoId = 24 },
                new ObraReparto { ObraId = 4, RepartoId = 25 },
                new ObraReparto { ObraId = 4, RepartoId = 26 },
                new ObraReparto { ObraId = 4, RepartoId = 27 },
                new ObraReparto { ObraId = 4, RepartoId = 28 },
                new ObraReparto { ObraId = 4, RepartoId = 29 },
                new ObraReparto { ObraId = 4, RepartoId = 30 },
                new ObraReparto { ObraId = 4, RepartoId = 31 },
                new ObraReparto { ObraId = 4, RepartoId = 32 },
                new ObraReparto { ObraId = 5, RepartoId = 33 },
                new ObraReparto { ObraId = 5, RepartoId = 34 },
                new ObraReparto { ObraId = 5, RepartoId = 35 },
                new ObraReparto { ObraId = 5, RepartoId = 36 },
                new ObraReparto { ObraId = 5, RepartoId = 37 },
                new ObraReparto { ObraId = 5, RepartoId = 38 },
                new ObraReparto { ObraId = 5, RepartoId = 39 },
                new ObraReparto { ObraId = 5, RepartoId = 40 },
                new ObraReparto { ObraId = 6, RepartoId = 41 },
                new ObraReparto { ObraId = 6, RepartoId = 42 },
                new ObraReparto { ObraId = 6, RepartoId = 43 },
                new ObraReparto { ObraId = 6, RepartoId = 44 },
                new ObraReparto { ObraId = 6, RepartoId = 45 },
                new ObraReparto { ObraId = 6, RepartoId = 46 },
                new ObraReparto { ObraId = 6, RepartoId = 47 },
                new ObraReparto { ObraId = 6, RepartoId = 48 },
                new ObraReparto { ObraId = 7, RepartoId = 49 },
                new ObraReparto { ObraId = 7, RepartoId = 50 },
                new ObraReparto { ObraId = 7, RepartoId = 51 },
                new ObraReparto { ObraId = 7, RepartoId = 52 },
                new ObraReparto { ObraId = 7, RepartoId = 53 },
                new ObraReparto { ObraId = 7, RepartoId = 54 },
                new ObraReparto { ObraId = 7, RepartoId = 55 },
                new ObraReparto { ObraId = 7, RepartoId = 56 },
                new ObraReparto { ObraId = 8, RepartoId = 57 },
                new ObraReparto { ObraId = 8, RepartoId = 58 },
                new ObraReparto { ObraId = 8, RepartoId = 59 },
                new ObraReparto { ObraId = 8, RepartoId = 60 },
                new ObraReparto { ObraId = 8, RepartoId = 61 },
                new ObraReparto { ObraId = 8, RepartoId = 62 },
                new ObraReparto { ObraId = 8, RepartoId = 63 },
                new ObraReparto { ObraId = 8, RepartoId = 64 },
                new ObraReparto { ObraId = 9, RepartoId = 65 },
                new ObraReparto { ObraId = 9, RepartoId = 66 },
                new ObraReparto { ObraId = 9, RepartoId = 67 },
                new ObraReparto { ObraId = 9, RepartoId = 68 },
                new ObraReparto { ObraId = 9, RepartoId = 69 },
                new ObraReparto { ObraId = 9, RepartoId = 70 },
                new ObraReparto { ObraId = 9, RepartoId = 71 },
                new ObraReparto { ObraId = 9, RepartoId = 72 },
                new ObraReparto { ObraId = 10, RepartoId = 73 },
                new ObraReparto { ObraId = 10, RepartoId = 74 },
                new ObraReparto { ObraId = 10, RepartoId = 75 },
                new ObraReparto { ObraId = 10, RepartoId = 76 },
                new ObraReparto { ObraId = 10, RepartoId = 77 },
                new ObraReparto { ObraId = 10, RepartoId = 78 },
                new ObraReparto { ObraId = 10, RepartoId = 79 },
                new ObraReparto { ObraId = 10, RepartoId = 80 },
                new ObraReparto { ObraId = 11, RepartoId = 81 },
                new ObraReparto { ObraId = 11, RepartoId = 82 },
                new ObraReparto { ObraId = 11, RepartoId = 83 },
                new ObraReparto { ObraId = 11, RepartoId = 84 },
                new ObraReparto { ObraId = 11, RepartoId = 85 },
                new ObraReparto { ObraId = 11, RepartoId = 86 },
                new ObraReparto { ObraId = 11, RepartoId = 87 },
                new ObraReparto { ObraId = 11, RepartoId = 88 },
                new ObraReparto { ObraId = 12, RepartoId = 89 },
                new ObraReparto { ObraId = 12, RepartoId = 90 },
                new ObraReparto { ObraId = 12, RepartoId = 91 },
                new ObraReparto { ObraId = 12, RepartoId = 92 },
                new ObraReparto { ObraId = 12, RepartoId = 93 },
                new ObraReparto { ObraId = 12, RepartoId = 94 },
                new ObraReparto { ObraId = 12, RepartoId = 95 },
                new ObraReparto { ObraId = 12, RepartoId = 96 }

           );

            modelBuilder.Entity<Butaca>().HasData(
                CrearButacas().ToList()

            );

            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(1).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(2).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );


        }


        public DbSet<Obra> Obras { get; set; }
        public DbSet<Butaca> Butacas { get; set; }
        public DbSet<Reparto> Repartos { get; set; }
        public DbSet<ObraReparto> ObraRepartos { get; set; }
        public DbSet<ButacaObra> ButacaObras { get; set; }

    }
}
