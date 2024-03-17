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
                new Obra { ObraId = 1, Titulo = "Don Juan", Title = "Don Juan",
                           Descripcion = "La obra 'Don Juan' es un clásico atemporal que explora las travesuras y el encanto del legendario seductor Don Juan. Esta pieza teatral icónica examina la naturaleza humana, el deseo, la moralidad y las consecuencias de nuestras acciones. A través de un cautivador relato, la historia sigue a Don Juan, un personaje carismático y seductor que desafía las normas sociales. Su irresistible magnetismo lo lleva a interactuar con una variedad de personajes, cada uno reflejando diferentes aspectos de la sociedad y la moralidad de la época. 'Don Juan' invita a reflexionar sobre la dualidad del ser humano, la moralidad, el amor y la libertad, envuelto en una trama llena de intriga y emociones intensas.", 
                           Description = "The play 'Don Juan' is a timeless classic that explores the mischief and charm of the legendary seducer Don Juan. This iconic theatrical piece examines human nature, desire, morality, and the consequences of our actions. Through a captivating narrative, the story follows Don Juan, a charismatic and seductive character who defies social norms. His irresistible magnetism leads him to interact with a variety of characters, each reflecting different aspects of society and morality of the time. 'Don Juan' invites reflection on the duality of human beings, morality, love, and freedom, wrapped in a plot full of intrigue and intense emotions.",DiaObra = new DateTime(2024, 03, 27, 20, 0, 0), Imagen = "donjuan.jpg", 
                           Reparto = "Luisa Fernández,Andrés Sánchez,María Gómez,Javier Rodríguez,Elena Pérez,Carlos Martínez,Ana Ruiz,Pedro Vázquez", Genero = "Romance", Gender = "Romance", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 2, Titulo = "La Celestina", Title = "The Celestine",
                           Descripcion = "'La Celestina' es una obra maestra de la literatura española escrita por Fernando de Rojas en el siglo XV. Esta tragicomedia narra la historia de amor entre Calisto y Melibea, en un contexto lleno de engaños, pasiones y traiciones. La trama se centra en la intervención de la alcahueta Celestina, una mujer astuta y manipuladora que actúa como intermediaria en el romance. A medida que avanza la historia, se entrelazan intrigas que revelan las complejidades de las relaciones humanas y critican la sociedad de la época. 'La Celestina' es reconocida por su profundidad psicológica en la construcción de personajes y su aguda crítica social, explorando temas como el amor, la codicia, el poder y la moralidad en un estilo literario cautivador.", 
                           Description = "'The Celestine' is a masterpiece of Spanish literature written by Fernando de Rojas in the 15th century. This tragicomedy tells the love story between Calisto and Melibea, within a context filled with deceit, passions, and betrayals. The plot revolves around the intervention of the go-between Celestina, a cunning and manipulative woman who acts as an intermediary in the romance. As the story unfolds, intrigues intertwine, revealing the complexities of human relationships and critiquing the society of the time. The Celestine is recognized for its psychological depth in character construction and its sharp social critique, exploring themes such as love, greed, power, and morality in a captivating literary style.", DiaObra = new DateTime(2024, 03, 28, 16, 0, 0), Imagen = "celestina.jpg",
                           Reparto = "Sofía Martínez, Diego López, Lucía García, Javier Rodríguez, Elena Pérez, Carlos Gómez, Ana Ruiz, Pedro Vázquez", Genero = "Romance", Gender = "Romance", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 3, Titulo = "Doble o nada", Title = "Doble o nada",
                           Descripcion = "Doble o nada es un thriller emocional ambientado en el hostil ambiente de las altas esferas empresariales. Una historia sobre el amor platónico, traición y engaño, y sobre todo, el poder y la ambición. Este emocionante thriller te mantendrá en vilo hasta el último minuto.", 
                           Description = "Doble o nada is an emotional thriller set in the hostile environment of high-level corporate circles. It's a story about unrequited love, betrayal, and deceit, but above all, about power and ambition. This thrilling suspense will keep you on the edge of your seat until the very last minute.", DiaObra = new DateTime(2024, 03, 31, 20, 30, 0), Imagen = "doble-o-nada.jpg", 
                           Reparto = "Laura Martínez,Diego López,Ana Fernández,Javier Gómez,Sofía Rodríguez,Andrés Pérez,Elena Ruiz,Carlos Martín", Genero = "Thriller", Gender = "Thriller", Duracion = 115, Precio = 20 },
                new Obra { ObraId = 4, Titulo = "Campeones", Title = "Campeones",
                           Descripcion = "Gloria y Josete se acaban de independizar bajo la tutela de Claudia. Ante la necesidad de encontrar un trabajo para poder tener un sueldo con el que mantenerse, Claudia les propone que intenten dedicarse a algo que les guste de verdad. Ellos quieren ser artistas. Para ello deberían encontrar un representante. Esta comedia hilarante sigue las aventuras de este trío en su búsqueda por la fama y la risa del público.", 
                           Description = "Gloria and Josete have just become independent under Claudia's guardianship. Faced with the need to find a job to be able to earn a salary to sustain themselves, Claudia suggests they try to pursue something they truly enjoy. They want to be artists. To do this, they should find a manager. This hilarious comedy follows the adventures of this trio in their quest for fame and the audience's laughter.", DiaObra = new DateTime(2024, 04, 04, 20, 0, 0), Imagen = "campeones.jpg", 
                           Reparto = "María García,Javier Martínez,Lucía Rodríguez,Andrés López,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez", Genero = "Comedia", Gender = "Comedy", Duracion = 140, Precio = 35 },
                new Obra { ObraId = 5, Titulo = "El mago Pop", Title = "El mago Pop" ,
                           Descripcion = "El Mago Pop es el nombre artístico de Antonio Díaz, un ilusionista español reconocido por sus impresionantes trucos de magia y espectáculos de ilusionismo. Conocido por combinar magia, tecnología y narrativa en sus actuaciones, El Mago Pop ha cautivado al público con sus shows innovadores y sorprendentes. Sus espectáculos suelen incorporar efectos visuales impactantes, interacción con el público y asombrosas ilusiones que desafían la lógica y la percepción. Antonio Díaz, como El Mago Pop, ha logrado llevar la magia a un nivel moderno y cautivador, convirtiéndose en uno de los ilusionistas más reconocidos a nivel internacional.",
                           Description = "The Mago Pop is the stage name of Antonio Díaz, a Spanish illusionist renowned for his impressive magic tricks and illusion shows. Known for combining magic, technology, and storytelling in his performances, The Mago Pop has captivated audiences with his innovative and astonishing shows. His performances often incorporate stunning visual effects, audience interaction, and amazing illusions that defy logic and perception. Antonio Díaz, as The Mago Pop, has succeeded in bringing magic to a modern and captivating level, becoming one of the most recognized illusionists internationally.", DiaObra = new DateTime(2024, 04, 05, 17, 30, 0), Imagen = "el-mago-pop.jpg", 
                           Reparto = "Javier Martínez, Lucía García, Andrés Fernández, María López, Carlos Ruiz, Elena Sánchez, Pedro González, Ana Martín", Genero = "Monologo", Gender = "Monologue", Duracion = 135, Precio = 30 },
                new Obra { ObraId = 6, Titulo = "El Rey Leon", Title = "The Lion King",
                           Descripcion = "El Rey León es un espectacular musical inspirado en la película de Disney que ha cautivado a audiencias de todo el mundo. Con música de Elton John y letras de Tim Rice, esta producción teatral transporta al público a la majestuosa sabana africana. La historia sigue el viaje de Simba, un joven león destinado a convertirse en rey, a través de sus aventuras, desafíos y el aprendizaje de valiosas lecciones sobre el honor, el coraje y el amor. El espectáculo se destaca por su impresionante puesta en escena, coloridos vestuarios, efectos visuales deslumbrantes y coreografías espectaculares. 'El Rey León' es una experiencia teatral emocionante y conmovedora, que combina la magia del cine con la energía y la emoción del teatro en vivo.", 
                           Description = "The Lion King is a spectacular musical inspired by the Disney movie that has captivated audiences worldwide. With music by Elton John and lyrics by Tim Rice, this theatrical production transports the audience to the majestic African savanna. The story follows the journey of Simba, a young lion destined to become king, through his adventures, challenges, and the learning of valuable lessons about honor, courage, and love. The show stands out for its impressive staging, colorful costumes, dazzling visual effects, and spectacular choreography. 'The Lion King' is an exciting and moving theatrical experience that combines the magic of cinema with the energy and emotion of live theater.",DiaObra = new DateTime(2024, 04, 07, 17, 0, 0), Imagen = "ElReyLeon3Aniv200.jpg", 
                           Reparto = "Sofía Martínez,Diego López,Lucía García,Javier Rodríguez,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez", Genero = "Musical", Gender = "Musical", Duracion = 100, Precio = 10 },
                new Obra { ObraId = 7, Titulo = "Fango", Title = "Fango",
                           Descripcion = "Fango es una obra teatral que aborda temas complejos y profundos relacionados con la condición humana, la lucha interna, la redención y las relaciones interpersonales. Esta obra se sumerge en la complejidad de los personajes y sus conflictos, explorando la naturaleza humana a través de diálogos intensos y situaciones emocionales. A menudo, Fango presenta una reflexión sobre la sociedad y sus injusticias, mostrando la lucha de los individuos por encontrar significado y redención en un mundo lleno de desafíos y adversidades.", 
                           Description = "Mud is a theatrical play that addresses complex and profound themes related to the human condition, internal struggle, redemption, and interpersonal relationships. This play delves into the complexity of the characters and their conflicts, exploring human nature through intense dialogues and emotional situations. Often, Mud offers a reflection on society and its injustices, showing individuals' struggle to find meaning and redemption in a world full of challenges and adversities.",DiaObra = new DateTime(2024, 03, 16, 12, 0, 0), Imagen = "fango.jpg", 
                           Reparto = "Sara Pérez,Javier García,Lucía Martínez,Andrés López,Elena Rodríguez,Carlos Fernández,María Gómez,Pedro Ruiz", Genero = "Monologo", Gender = "Monologue", Duracion = 90, Precio = 40 },
                new Obra { ObraId = 8, Titulo = "La Funcion que Sale Mal", Title = "La Funcion que Sale Mal",
                           Descripcion = "La función que sale mal es una obra teatral cómica que gira en torno a un grupo de actores aficionados que intentan representar una obra de teatro, pero todo lo que puede salir mal ¡sale mal! La trama se desarrolla con una sucesión de desastres cómicos, desde problemas técnicos hasta errores de actuación y malentendidos entre los personajes. La obra es una comedia llena de situaciones hilarantes y caóticas que mantienen al público riendo a carcajadas. 'La función que sale mal' es conocida por su humor físico, su ingenio y su capacidad para convertir los errores en momentos divertidos e inolvidables para el público.",
                           Description = "La función que sale mal is a comedic theatrical production that revolves around a group of amateur actors attempting to stage a play, but everything that can go wrong does go wrong! The plot unfolds with a succession of comic disasters, from technical problems to acting mishaps and misunderstandings among the characters. The play is a comedy filled with hilarious and chaotic situations that keep the audience laughing out loud. 'The Play That Goes Wrong' is known for its physical humor, wit, and ability to turn mistakes into entertaining and unforgettable moments for the audience.", DiaObra = new DateTime(2024, 04, 12, 19, 0, 0), Imagen = "funcion-sale.mal.jpg", 
                           Reparto = "Sofía Martínez, Diego López, Lucía García, Javier Rodríguez, Elena Pérez, Carlos Gómez, Ana Ruiz, Pedro Vázquez", Genero = "Thriller", Gender = "Thriller", Duracion = 110, Precio = 30 },
                new Obra { ObraId = 9, Titulo = "Ilusionate", Title = "Ilusionate",
                           Descripcion = "Ilusionate es una emocionante obra de teatro que fusiona el ilusionismo, la magia y el drama en una experiencia teatral única. Esta obra cautivadora transporta al público a un mundo de sorpresas, ilusiones y emociones. Con un elenco talentoso y efectos visuales impactantes, Ilusionate combina la magia del teatro con increíbles trucos y narrativas que mantienen al espectador absorto en un viaje lleno de misterio y asombro. Esta obra teatral es una oportunidad para sumergirse en un universo de ilusiones y disfrutar de un espectáculo que desafía la imaginación y la percepción.", 
                           Description = "Illuminate is an exciting theatrical production that blends illusionism, magic, and drama into a unique theatrical experience. This captivating play transports the audience to a world of surprises, illusions, and emotions. With a talented cast and stunning visual effects, Illuminate combines the magic of theater with incredible tricks and narratives that keep the viewer absorbed in a journey full of mystery and wonder. This theatrical production is an opportunity to immerse oneself in a universe of illusions and enjoy a show that challenges the imagination and perception.", DiaObra = new DateTime(2024, 04, 15, 18, 15, 0), Imagen = "ilusionate.jpg", 
                           Reparto = "Sofía Martínez,Diego López,Lucía García,Javier Rodríguez,Elena Pérez,Carlos Gómez,Ana Ruiz,Pedro Vázquez", Genero = "Monologo", Gender = "Monologue", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 10, Titulo = "Jose el soñador", Title = "Jose the dreamer",
                           Descripcion = "José el Soñador es una historia bíblica que relata la vida de José, hijo de Jacob, vendido como esclavo por sus hermanos. La historia sigue la vida de José desde su juventud hasta convertirse en un importante funcionario en Egipto. Conocida por su narrativa llena de intriga, traición y redención, la historia muestra la habilidad de José para interpretar sueños, lo que lo lleva a ganar el favor del faraón y a desempeñar un papel crucial en la historia de Egipto. 'José el Soñador' es un relato emocionante que explora temas de fe, perseverancia y perdón, y ha sido una fuente de inspiración para muchas personas a lo largo de los siglos.", 
                           Description = "Jose the dreamer is a biblical tale that recounts the life of Joseph, son of Jacob, sold into slavery by his brothers. The story follows Joseph's life from his youth to becoming a prominent official in Egypt. Known for its narrative filled with intrigue, betrayal, and redemption, the story showcases Joseph's ability to interpret dreams, which leads him to gain favor with the pharaoh and play a crucial role in Egypt's history. 'Joseph the Dreamer' is an exciting narrative that explores themes of faith, perseverance, and forgiveness, and has been a source of inspiration for many people throughout the centuries.", DiaObra = new DateTime(2024, 04, 16, 12, 0, 0), Imagen = "jose-el-sonador.jpg", 
                           Reparto = "Ana García,Luis Martínez,María Fernández,Javier Rodríguez,Elena Pérez,Carlos Sánchez,Lucía Martín,Andrés Gómez", Genero = "Drama", Gender = "Drama", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 11, Titulo = "Laponia", Title = "Lapland",
                           Descripcion = "Laponia es una región situada en el norte de Europa que abarca partes de Noruega, Suecia, Finlandia y Rusia. Conocida por su belleza natural y su paisaje ártico, Laponia es famosa por ser el hogar de la gente sami, su cultura única y las auroras boreales que se pueden observar durante la temporada de invierno. Esta región ofrece una amplia gama de actividades, como safaris en trineo de perros, excursiones para avistar renos, esquí, senderismo y la oportunidad de experimentar la cultura sami a través de sus tradiciones, como la artesanía, la música y la gastronomía local. Laponia es un destino popular para aquellos que buscan aventuras inolvidables en un entorno natural espectacular.", 
                           Description = "Lapland is a region located in northern Europe that spans parts of Norway, Sweden, Finland, and Russia. Known for its natural beauty and Arctic landscape, Lapland is famous for being home to the Sami people, their unique culture, and the Northern Lights that can be observed during the winter season. This region offers a wide range of activities such as dog sledding safaris, reindeer spotting excursions, skiing, hiking, and the opportunity to experience Sami culture through their traditions such as craftsmanship, music, and local cuisine. Lapland is a popular destination for those seeking unforgettable adventures in a spectacular natural environment.", DiaObra = new DateTime(2024, 04, 19, 16, 0, 0), Imagen = "laponia.jpg", 
                           Reparto = "Erik Larsson, Ingrid Johansson,Sven Andersson,Hanna Bergman,Frida Nilsson,Oskar Magnusson,Emma Karlsson,Viktor Lindström", Genero = "Thriller", Gender = "Thriller", Duracion = 125, Precio = 20 },
                new Obra { ObraId = 12, Titulo = "Las mil y una noches", Title = "Arabian Nights",
                           Descripcion = "Las Mil y Una Noches es una colección de cuentos y fábulas de origen árabe que se remonta a varios siglos. La historia principal sigue a Scheherezade, quien cuenta historias al rey Shahriar para evitar su ejecución. Estas historias incluyen relatos mágicos, aventuras, fábulas morales y cuentos populares que abarcan un amplio espectro de géneros y temas. Entre los cuentos más conocidos se encuentran 'Aladino y la lámpara maravillosa', 'Simbad el marino' y 'Ali Baba y los cuarenta ladrones'. 'Las Mil y Una Noches' ha cautivado a lectores durante generaciones con su riqueza narrativa, su imaginación desbordante y su habilidad para entrelazar historias encantadoras y emocionantes.", 
                           Description = "Arabian Nights is a collection of tales and fables of Arabic origin that dates back several centuries. The main story follows Scheherazade, who tells stories to King Shahriar to avoid her execution. These stories include magical tales, adventures, moral fables, and popular tales that span a wide spectrum of genres and themes. Among the most well-known tales are 'Aladdin and the Magic Lamp', 'Sinbad the Sailor', and 'Ali Baba and the Forty Thieves'. 'The Thousand and One Nights' has captivated readers for generations with its narrative richness, boundless imagination, and ability to weave charming and thrilling stories together.", DiaObra = new DateTime(2024, 05, 01, 18, 0, 0), Imagen = "las-mil-y-una-noches.jpg", 
                           Reparto = "Leyla Khan,Amir Shah,Jamil Ahmed,Nadia Malik,Karim Hassan,Ayesha Khan,Rashid Ali,Yasir Mahmood", Genero = "Comedia", Gender="Comedy", Duracion = 30, Precio = 25 }
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
