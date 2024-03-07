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

        public ObraEFRepository(ObraContext context)
        {

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
                    Descripcion = o.Descripcion,
                    DiaObra = o.DiaObra,
                    Imagen = o.Imagen,
                    Genero = o.Genero,
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
                    Descripcion = obra.Descripcion,
                    DiaObra = obra.DiaObra,
                    Imagen = obra.Imagen,
                    Genero = obra.Genero,
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
            // Verificar si ya hay una instancia de Obra con el mismo ObraId en el contexto
            var existingObra = _context.Obras.Find(obra.ObraId);

            if (existingObra != null)
            {
                // Si existe una instancia previa, desvincularla del contexto
                _context.Entry(existingObra).State = EntityState.Detached;
            }

            // Adjuntar la nueva instancia de Obra al contexto
            _context.Attach(obra);

            // Marcar la entidad como modificada para que Entity Framework la actualice en la base de datos
            _context.Entry(obra).State = EntityState.Modified;

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
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