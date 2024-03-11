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

        public List<ButacaDTO> GetAll()
        {
            var seats = _context.ButacaObras
               .ToList();

            if (seats != null)
            {
                var seatDto = seats.Select(o => new ButacaDTO
                {
                    ObraId = o.ObraId,
                    ButacaId = o.ButacaId,
                    Libre = o.Libre,
                }).ToList();
                return seatDto;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Add(ButacaObra seat)
        {
            if (seat.ButacaId >= 1 && seat.ButacaId <= 100)
            {
                _context.ButacaObras.Add(seat);
                SaveChanges();
            }else{
                throw new Exception("Exceded number of seats");
            }
            

        }

        public ButacaDTO GetSeat(int idFunction, int idSeat)
        {
            var seat = _context.ButacaObras
                .Where(seat => seat.ObraId == idFunction && seat.ButacaId == idSeat)
                .FirstOrDefault();

            if (seat != null)
            {
                var seatDto = new ButacaDTO
                {
                    ObraId = seat.ObraId,
                    ButacaId = seat.ButacaId,

                };

                return seatDto;
            }
            else
            {
                return null; // Indicar que no se encontró ninguna butaca
            }
        }

        //return all seats from 1 function
        public List<ButacaDTO> GetFromFunction(int idFunction)
        {
            var seats = _context.ButacaObras
                            .Where(seat => seat.ObraId == idFunction)
                            .ToList();

            if (seats != null)
            {
                var seatDto = seats.Select(o => new ButacaDTO
                {
                    ObraId = o.ObraId,
                    ButacaId = o.ButacaId,
                    Libre = o.Libre,
                }).ToList();
                return seatDto;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }


        public void Update(ButacaObra seat)
        {
            // _context.Entry(seat).State = EntityState.Modified;
            // SaveChanges();
            var existingSeat = _context.ButacaObras.Find(seat.ObraId, seat.ButacaId);

            if (existingSeat != null)
            {
                // Si existe una instancia previa, desvincularla del contexto
                _context.Entry(existingSeat).State = EntityState.Detached;
            }

            // Adjuntar la nueva instancia de Obra al contexto
            _context.Attach(seat);

            // Marcar la entidad como modificada para que Entity Framework la actualice en la base de datos
            _context.Entry(seat).State = EntityState.Modified;

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
        }

        public void Delete(int idFunction, int idSeat)
        {
            var seatDto = GetSeat(idFunction, idSeat);
            if (seatDto is null)
            {
                throw new KeyNotFoundException("Pizza not found.");
            }
            var seat = _context.ButacaObras.FirstOrDefault(o => o.ObraId == idFunction && o.ButacaId == idSeat);
            if (seat != null)
            {
                _context.ButacaObras.Remove(seat);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}