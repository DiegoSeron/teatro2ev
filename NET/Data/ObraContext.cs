using System.Collections.Generic;
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

            modelBuilder.Entity<User>()
                .HasKey(u => new { u.UserId });
            
            
            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, Titulo = "Don Juan",
                           Descripcion = "La obra 'Don Juan' es un clásico atemporal que explora las travesuras y el encanto del legendario seductor Don Juan. Esta pieza teatral icónica examina la naturaleza humana, el deseo, la moralidad y las consecuencias de nuestras acciones. A través de un cautivador relato, la historia sigue a Don Juan, un personaje carismático y seductor que desafía las normas sociales. Su irresistible magnetismo lo lleva a interactuar con una variedad de personajes, cada uno reflejando diferentes aspectos de la sociedad y la moralidad de la época. 'Don Juan' invita a reflexionar sobre la dualidad del ser humano, la moralidad, el amor y la libertad, envuelto en una trama llena de intriga y emociones intensas.", DiaObra = new DateTime(2024, 03, 27, 20, 0, 0), Imagen = "donjuan.jpg", 
                           Reparto = "Luisa Fernández,Andrés Sánchez,María Gómez,Javier Rodríguez,Elena Pérez,Carlos Martínez,Ana Ruiz,Pedro Vázquez", Genero = "Romance", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 2, Titulo = "La Celestina",
                           Descripcion = "'La Celestina' es una obra maestra de la literatura española escrita por Fernando de Rojas en el siglo XV. Esta tragicomedia narra la historia de amor entre Calisto y Melibea, en un contexto lleno de engaños, pasiones y traiciones. La trama se centra en la intervención de la alcahueta Celestina, una mujer astuta y manipuladora que actúa como intermediaria en el romance. A medida que avanza la historia, se entrelazan intrigas que revelan las complejidades de las relaciones humanas y critican la sociedad de la época. 'La Celestina' es reconocida por su profundidad psicológica en la construcción de personajes y su aguda crítica social, explorando temas como el amor, la codicia, el poder y la moralidad en un estilo literario cautivador.", DiaObra = new DateTime(2024, 03, 28, 16, 0, 0), Imagen = "celestina.jpg",
                           Reparto = "Sofía Martínez, Diego López, Lucía García, Javier Rodríguez, Elena Pérez, Carlos Gómez, Ana Ruiz, Pedro Vázquez", Genero = "Romance", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 3, Titulo = "Doble o nada",
                           Descripcion = "Doble o nada es un thriller emocional ambientado en el hostil ambiente de las altas esferas empresariales. Una historia sobre el amor platónico, traición y engaño, y sobre todo, el poder y la ambición. Este emocionante thriller te mantendrá en vilo hasta el último minuto.", DiaObra = new DateTime(2024, 03, 31, 20, 30, 0), Imagen = "doble-o-nada.jpg", 
                           Reparto = "Laura Martínez,Diego López,Ana Fernández,Javier Gómez,Sofía Rodríguez,Andrés Pérez,Elena Ruiz,Carlos Martín", Genero = "Thriller", Duracion = 115, Precio = 20 },
                new Obra { ObraId = 4, Titulo = "Campeones",
                           Descripcion = "Gloria y Josete se acaban de independizar bajo la tutela de Claudia. Ante la necesidad de encontrar un trabajo para poder tener un sueldo con el que mantenerse, Claudia les propone que intenten dedicarse a algo que les guste de verdad. Ellos quieren ser artistas. Para ello deberían encontrar un representante. Esta comedia hilarante sigue las aventuras de este trío en su búsqueda por la fama y la risa del público.", DiaObra = new DateTime(2024, 04, 04, 20, 0, 0), Imagen = "campeones.jpg", 
                           Reparto = "María García,Javier Martínez,Lucía Rodríguez,Andrés López,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez", Genero = "Comedia", Duracion = 140, Precio = 35 },
                new Obra { ObraId = 5, Titulo = "El mago Pop",
                           Descripcion = "El Mago Pop es el nombre artístico de Antonio Díaz, un ilusionista español reconocido por sus impresionantes trucos de magia y espectáculos de ilusionismo. Conocido por combinar magia, tecnología y narrativa en sus actuaciones, El Mago Pop ha cautivado al público con sus shows innovadores y sorprendentes. Sus espectáculos suelen incorporar efectos visuales impactantes, interacción con el público y asombrosas ilusiones que desafían la lógica y la percepción. Antonio Díaz, como El Mago Pop, ha logrado llevar la magia a un nivel moderno y cautivador, convirtiéndose en uno de los ilusionistas más reconocidos a nivel internacional.", DiaObra = new DateTime(2024, 04, 05, 17, 30, 0), Imagen = "el-mago-pop.jpg", 
                           Reparto = "Javier Martínez, Lucía García, Andrés Fernández, María López, Carlos Ruiz, Elena Sánchez, Pedro González, Ana Martín", Genero = "Monologo", Duracion = 135, Precio = 30 },
                new Obra { ObraId = 6, Titulo = "El Rey Leon",
                           Descripcion = "El Rey León es un espectacular musical inspirado en la película de Disney que ha cautivado a audiencias de todo el mundo. Con música de Elton John y letras de Tim Rice, esta producción teatral transporta al público a la majestuosa sabana africana. La historia sigue el viaje de Simba, un joven león destinado a convertirse en rey, a través de sus aventuras, desafíos y el aprendizaje de valiosas lecciones sobre el honor, el coraje y el amor. El espectáculo se destaca por su impresionante puesta en escena, coloridos vestuarios, efectos visuales deslumbrantes y coreografías espectaculares. 'El Rey León' es una experiencia teatral emocionante y conmovedora, que combina la magia del cine con la energía y la emoción del teatro en vivo.", DiaObra = new DateTime(2024, 04, 07, 17, 0, 0), Imagen = "ElReyLeon3Aniv200.jpg", 
                           Reparto = "Sofía Martínez,Diego López,Lucía García,Javier Rodríguez,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez", Genero = "Musical", Duracion = 100, Precio = 10 },
                new Obra { ObraId = 7, Titulo = "Fango",
                           Descripcion = "Fango es una obra teatral que aborda temas complejos y profundos relacionados con la condición humana, la lucha interna, la redención y las relaciones interpersonales. Esta obra se sumerge en la complejidad de los personajes y sus conflictos, explorando la naturaleza humana a través de diálogos intensos y situaciones emocionales. A menudo, Fango presenta una reflexión sobre la sociedad y sus injusticias, mostrando la lucha de los individuos por encontrar significado y redención en un mundo lleno de desafíos y adversidades.", DiaObra = new DateTime(2024, 03, 16, 12, 0, 0), Imagen = "fango.jpg", 
                           Reparto = "Sara Pérez,Javier García,Lucía Martínez,Andrés López,Elena Rodríguez,Carlos Fernández,María Gómez,Pedro Ruiz", Genero = "Monologo", Duracion = 90, Precio = 40 },
                new Obra { ObraId = 8, Titulo = "La Funcion que Sale Mal",
                           Descripcion = "La función que sale mal es una obra teatral cómica que gira en torno a un grupo de actores aficionados que intentan representar una obra de teatro, pero todo lo que puede salir mal ¡sale mal! La trama se desarrolla con una sucesión de desastres cómicos, desde problemas técnicos hasta errores de actuación y malentendidos entre los personajes. La obra es una comedia llena de situaciones hilarantes y caóticas que mantienen al público riendo a carcajadas. 'La función que sale mal' es conocida por su humor físico, su ingenio y su capacidad para convertir los errores en momentos divertidos e inolvidables para el público.", DiaObra = new DateTime(2024, 04, 12, 19, 0, 0), Imagen = "funcion-sale.mal.jpg", 
                           Reparto = "Sofía Martínez, Diego López, Lucía García, Javier Rodríguez, Elena Pérez, Carlos Gómez, Ana Ruiz, Pedro Vázquez", Genero = "Thriller", Duracion = 110, Precio = 30 },
                new Obra { ObraId = 9, Titulo = "Ilusionate",
                           Descripcion = "Ilusionate es una emocionante obra de teatro que fusiona el ilusionismo, la magia y el drama en una experiencia teatral única. Esta obra cautivadora transporta al público a un mundo de sorpresas, ilusiones y emociones. Con un elenco talentoso y efectos visuales impactantes, Ilusionate combina la magia del teatro con increíbles trucos y narrativas que mantienen al espectador absorto en un viaje lleno de misterio y asombro. Esta obra teatral es una oportunidad para sumergirse en un universo de ilusiones y disfrutar de un espectáculo que desafía la imaginación y la percepción.",  DiaObra = new DateTime(2024, 04, 15, 18, 15, 0), Imagen = "ilusionate.jpg", 
                           Reparto = "Sofía Martínez,Diego López,Lucía García,Javier Rodríguez,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez", Genero = "Monologo", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 10, Titulo = "Jose el soñador",
                           Descripcion = "José el Soñador es una historia bíblica que relata la vida de José, hijo de Jacob, vendido como esclavo por sus hermanos. La historia sigue la vida de José desde su juventud hasta convertirse en un importante funcionario en Egipto. Conocida por su narrativa llena de intriga, traición y redención, la historia muestra la habilidad de José para interpretar sueños, lo que lo lleva a ganar el favor del faraón y a desempeñar un papel crucial en la historia de Egipto. 'José el Soñador' es un relato emocionante que explora temas de fe, perseverancia y perdón, y ha sido una fuente de inspiración para muchas personas a lo largo de los siglos.",  DiaObra = new DateTime(2024, 04, 16, 12, 0, 0), Imagen = "jose-el-sonador.jpg", 
                           Reparto = "Ana García,Luis Martínez,María Fernández,Javier Rodríguez,Elena Pérez,Carlos Sánchez,Lucía Martín,Andrés Gómez", Genero = "Drama", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 11, Titulo = "Laponia",
                           Descripcion = "Laponia es una región situada en el norte de Europa que abarca partes de Noruega, Suecia, Finlandia y Rusia. Conocida por su belleza natural y su paisaje ártico, Laponia es famosa por ser el hogar de la gente sami, su cultura única y las auroras boreales que se pueden observar durante la temporada de invierno. Esta región ofrece una amplia gama de actividades, como safaris en trineo de perros, excursiones para avistar renos, esquí, senderismo y la oportunidad de experimentar la cultura sami a través de sus tradiciones, como la artesanía, la música y la gastronomía local. Laponia es un destino popular para aquellos que buscan aventuras inolvidables en un entorno natural espectacular.", DiaObra = new DateTime(2024, 04, 19, 16, 0, 0), Imagen = "laponia.jpg", 
                           Reparto = "Erik Larsson, Ingrid Johansson,Sven Andersson,Hanna Bergman,Frida Nilsson,Oskar Magnusson,Emma Karlsson,Viktor Lindström", Genero = "Thriller", Duracion = 125, Precio = 20 },
                new Obra { ObraId = 12, Titulo = "Las mil y una noches",
                           Descripcion = "Las Mil y Una Noches es una colección de cuentos y fábulas de origen árabe que se remonta a varios siglos. La historia principal sigue a Scheherezade, quien cuenta historias al rey Shahriar para evitar su ejecución. Estas historias incluyen relatos mágicos, aventuras, fábulas morales y cuentos populares que abarcan un amplio espectro de géneros y temas. Entre los cuentos más conocidos se encuentran 'Aladino y la lámpara maravillosa', 'Simbad el marino' y 'Ali Baba y los cuarenta ladrones'. 'Las Mil y Una Noches' ha cautivado a lectores durante generaciones con su riqueza narrativa, su imaginación desbordante y su habilidad para entrelazar historias encantadoras y emocionantes.", DiaObra = new DateTime(2024, 05, 01, 18, 0, 0), Imagen = "las-mil-y-una-noches.jpg", 
                           Reparto = "Leyla Khan,Amir Shah,Jamil Ahmed,Nadia Malik,Karim Hassan,Ayesha Khan,Rashid Ali,Yasir Mahmood", Genero = "Comedia", Duracion = 30, Precio = 25 }
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
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(3).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(4).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(5).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(6).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(7).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(8).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(9).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(10).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(11).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<ButacaObra>().HasData(
                CrearButacasObra(12).ToList() // Crea una nueva butaca con ButacaId = 1 y Libre = true
            );
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Admin", Email = "admin@gmail.com", Password = "Admin1234" },
                new User { UserId = 2, Name = "User1", Email = "user1@gmail.com", Password = "User1" }
            );
        }


        public DbSet<Obra> Obras { get; set; }
        public DbSet<Butaca> Butacas { get; set; }
        public DbSet<ButacaObra> ButacaObras { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
