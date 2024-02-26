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
        private IEnumerable<Butaca> GenerarButacas(int finButacaId, int obraId)
        {
            var butacas = new List<Butaca>();
            for (int i = 1; i <= finButacaId; i++)
            {
                butacas.Add(new Butaca { ObraId =  obraId, ButacaId = i, Libre = true });
            }
            return butacas;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Obra>().HasKey(o => o.ObraId);

            modelBuilder.Entity<Obra>()
                .HasMany(o => o.ListaButaca)
                .WithOne()
                .HasForeignKey("ObraId")
                .OnDelete(DeleteBehavior.Cascade);

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




            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, Titulo = "Don Juan", Descripcion = "false", DiaObra = new DateTime(2024, 01, 13), Imagen = "donjuan.jpg", Genero = "Drama", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 2, Titulo = "Celestina", Descripcion = "false", DiaObra = new DateTime(2024, 01, 25), Imagen = "celestina.jpg", Genero = "Drama", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 3, Titulo = "Doble o nada", Descripcion = "false", DiaObra = new DateTime(2024, 02, 7), Imagen = "doble-o-nada.jpg", Genero = "Drama", Duracion = 115, Precio = 20 },
                new Obra { ObraId = 4, Titulo = "Campeones", Descripcion = "false", DiaObra = new DateTime(2024, 02, 15), Imagen = "campeones.jpg", Genero = "Drama", Duracion = 140, Precio = 35 },
                new Obra { ObraId = 5, Titulo = "El mago Pop", Descripcion = "false", DiaObra = new DateTime(2024, 02, 29), Imagen = "el-mago-pop.jpg", Genero = "Drama", Duracion = 135, Precio = 30 },
                new Obra { ObraId = 6, Titulo = "El Rey Leon", Descripcion = "false", DiaObra = new DateTime(2024, 03, 03), Imagen = "ElReyLeon3Aniv200.jpg", Genero = "Drama", Duracion = 100, Precio = 10 },
                new Obra { ObraId = 7, Titulo = "Fango", Descripcion = "false", DiaObra = new DateTime(2024, 03, 16), Imagen = "fango.jpg", Genero = "Drama", Duracion = 90, Precio = 40 },
                new Obra { ObraId = 8, Titulo = "La Funcion que Sale Mal", Descripcion = "false", DiaObra = new DateTime(2024, 03, 21), Imagen = "funcion-sale.mal.jpg", Genero = "Drama", Duracion = 110, Precio = 30 },
                new Obra { ObraId = 9, Titulo = "Ilusionate", Descripcion = "false", DiaObra = new DateTime(2024, 04, 04), Imagen = "ilusionate.jpg", Genero = "Drama", Duracion = 120, Precio = 15 },
                new Obra { ObraId = 10, Titulo = "Jose el soñador", Descripcion = "false", DiaObra = new DateTime(2024, 04, 10), Imagen = "jose-el-sonador.jpg", Genero = "Drama", Duracion = 105, Precio = 25 },
                new Obra { ObraId = 11, Titulo = "Laponia", Descripcion = "false", DiaObra = new DateTime(2024, 04, 23), Imagen = "laponia.jpg", Genero = "Drama", Duracion = 125, Precio = 20 },
                new Obra { ObraId = 12, Titulo = "Las mil y una noches", Descripcion = "false", DiaObra = new DateTime(2024, 05, 01), Imagen = "las-mil-y-una-noches.jpg", Genero = "Drama", Duracion = 30, Precio = 25 }

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
                new Butaca { ObraId = 1, ButacaId = 1, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 2, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 3, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 4, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 5, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 6, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 7, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 8, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 9, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 10, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 11, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 12, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 13, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 14, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 15, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 16, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 17, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 18, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 19, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 20, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 21, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 22, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 23, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 24, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 25, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 26, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 27, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 28, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 29, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 30, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 31, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 32, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 33, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 34, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 35, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 36, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 37, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 38, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 39, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 40, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 41, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 42, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 43, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 44, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 45, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 46, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 47, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 48, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 49, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 50, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 51, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 52, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 53, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 54, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 55, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 56, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 57, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 58, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 59, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 60, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 61, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 62, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 63, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 64, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 65, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 66, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 67, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 68, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 69, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 70, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 71, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 72, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 73, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 74, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 75, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 76, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 77, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 78, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 79, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 80, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 81, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 82, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 83, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 84, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 85, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 86, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 87, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 88, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 89, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 90, Libre = true },
                new Butaca { ObraId = 1, ButacaId = 91, Libre = true }
            );

        }
        

        public DbSet<Obra> Obras { get; set; }
        public DbSet<Butaca> Butacas { get; set; }
        public DbSet<Reparto> Repartos { get; set; }
        public DbSet<ObraReparto> ObraRepartos { get; set; }

    }
}
