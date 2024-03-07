using Tickett.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Tickett.Data;

namespace Tickett.Data
{

    public class SeatEFRepository : ISeatRepository
    {


        private readonly ObraContext _context;

        public SeatEFRepository(ObraContext context)
        {

            _context = context;
        }

        public List<ButacaObra> GetAll()
        {
            return _context.ButacaObras.ToList();
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

        public void Add(ButacaObra seat)
        {
            _context.ButacaObras.Add(seat);
            SaveChanges();
        }

        public void AddRange(IEnumerable<ButacaObra> butacas)
    {
        _context.Set<ButacaObra>().AddRange(butacas);
        _context.SaveChanges();
    }

        public ButacaObra GetSeat(int idFunction, int idSeat)
        {
            return _context.ButacaObras.FirstOrDefault(obra => obra.ObraId == idFunction && obra.ButacaId == idSeat);
        }

        public List<ButacaObra> GetFromFunction(int idFunction)
        {
            return _context.ButacaObras.Where(obra => obra.ObraId == idFunction).ToList();

        }


        public void Update(ButacaObra seat)
        {
            _context.Entry(seat).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int idFunction, int idSeat)
        {
            var seat = GetSeat(idFunction, idSeat);
            if (seat is null)
            {
                throw new KeyNotFoundException("Pizza not found.");
            }
            _context.ButacaObras.Remove(seat);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}