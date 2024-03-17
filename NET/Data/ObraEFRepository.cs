using Tickett.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Tickett.Data;

namespace Tickett.Data
{

    public class ObraEFRepository : IObraRepository
    {


        private readonly ObraContext _context;
        private readonly ISeatRepository _seatRepository;

        public ObraEFRepository(ObraContext context, ISeatRepository seatRepository)
        {
            _seatRepository = seatRepository;
            _context = context;
        }

        public List<ObraDTO> GetAll()
        {
            var obras = _context.Obras
                .Include(b => b.ListaButacaObra)
                    .ThenInclude(bo => bo.Butaca)
                .ToList();

            if (obras != null)
            {
                var obraDto = obras.Select(o => new ObraDTO
                {
                    ObraId = o.ObraId,
                    Titulo = o.Titulo,
                    Title = o.Title,
                    Descripcion = o.Descripcion,
                    Description = o.Description,
                    DiaObra = o.DiaObra,
                    Imagen = o.Imagen,
                    Reparto = o.Reparto,
                    Genero = o.Genero,
                    Gender = o.Gender,
                    Duracion = o.Duracion,
                    Precio = o.Precio,
                    Butacas = o.ListaButacaObra
                    .Where(bo => bo != null && bo.Butaca != null)
                    .Select(bo => new ButacaDTO
                    {
                        ButacaId = bo.ButacaId,
                        Libre = bo.Libre ? true : false
                    }).ToList()
                }).ToList();
                return obraDto;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Add(Obra obra)
        {
            _context.Obras.Add(obra);
            SaveChanges();

            for (int i = 1; i <= 100; i++)
            {
                var butaca = new ButacaObra
                {
                    ObraId = obra.ObraId,
                    ButacaId = i,
                    Libre = true // Suponiendo que al principio todas las butacas están libres
                };
                _seatRepository.Add(butaca);


                // Aquí puedes realizar cualquier otra lógica que necesites
            }
            SaveChanges();
        }

        public ObraDTO Get(int id)
        {
            var obra = _context.Obras
                .Include(b => b.ListaButacaObra)
                    .ThenInclude(bo => bo.Butaca)
                .Where(obra => obra.ObraId == id)
                .FirstOrDefault();

            if (obra != null)
            {
                var obraDto = new ObraDTO
                {
                    ObraId = obra.ObraId,
                    Titulo = obra.Titulo,
                    Title = obra.Title,
                    Descripcion = obra.Descripcion,
                    Description = obra.Description,
                    DiaObra = obra.DiaObra,
                    Imagen = obra.Imagen,
                    Reparto = obra.Reparto,
                    Genero = obra.Genero,
                    Gender = obra.Gender,
                    Duracion = obra.Duracion,
                    Precio = obra.Precio,
                    Butacas = obra.ListaButacaObra
                        .Where(bo => bo != null && bo.Butaca != null) // Verificar que bo y bo.Butaca no sean null
                        .Select(bo => new ButacaDTO
                        {
                            ButacaId = bo.ButacaId,
                            Libre = bo.Libre ? true : false // Suponiendo que el estado depende de la propiedad "Libre" de la butaca
                        }).ToList()
                };

                return obraDto;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }

        }

        public void Update(Obra obra)
        {
            // Cargar la instancia existente de Obra desde el contexto
            var existingObra = _context.Obras.Find(obra.ObraId);

            if (existingObra != null)
            {
                // Copiar las propiedades actualizadas de la nueva instancia a la instancia existente
                _context.Entry(existingObra).CurrentValues.SetValues(obra);

                // Guardar los cambios en el contexto
                _context.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            var obraDto = Get(id);
            if (obraDto == null)
            {
                throw new KeyNotFoundException("Obra not found.");
            }

            var obra = _context.Obras.FirstOrDefault(o => o.ObraId == id);
            if (obra != null)
            {
                _context.Obras.Remove(obra);
                SaveChanges();
            }
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}