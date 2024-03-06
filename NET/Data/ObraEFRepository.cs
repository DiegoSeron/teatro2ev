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

        public List<Obra> GetAll()
        {
            return _context.Obras.ToList();
            // var pizzas = _context.Pizzas
            //     .Include(p => p.PizzaIngredientes)
            //         .ThenInclude(pi => pi.Ingrediente)
            //     .ToList();

            // var pizzasDto = pizzas.Select(p => new PizzaDto
            // {
            //     Id = p.Id,
            //     Name = p.Name,
            //     PizzaIngredientes = p.PizzaIngredientes.Select(pi => new IngredienteDto
            //     {
            //         Id = pi.Ingrediente.Id,
            //         Name = pi.Ingrediente.Name
            //     }).ToList()
            // }).ToList();

            // return pizzasDto;
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
                .Where(obra => obra.ObraId == id)
                .FirstOrDefault();

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
                Butacas = obra.ListaButacaObra.Select(bo => new ButacaDTO
                {
                    ButacaId = bo.Butaca.ButacaId,
                    Libre = bo.Butaca.Libre
                }).ToList()
            };
            return obraDto;
        }

        public void Update(Obra obra)
        {
            _context.Entry(obra).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var obra = Get(id);
            if (obra is null)
            {
                throw new KeyNotFoundException("Pizza not found.");
            }
            _context.Obras.Remove(obra);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}