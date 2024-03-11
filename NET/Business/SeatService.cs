using Tickett.Data;
using Tickett.Models;


namespace Tickett.Business
{
    public class SeatService : ISeatService
    {

        private readonly ISeatRepository _seatRepository;
        

        public SeatService(ISeatRepository seatRepository){
            _seatRepository = seatRepository;
        
        }
        public  List<ButacaDTO> GetAll()
        {
            var seats = _seatRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return seats;
        }

        public  ButacaDTO GetSeat(int idFunction, int idSeat)
        {
            var seat = _seatRepository.GetSeat(idFunction, idSeat);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return seat;
        }

        public  List<ButacaDTO> GetFromFunction(int idFunction)
        {
            var seat = _seatRepository.GetFromFunction(idFunction);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return seat;
        }
          

    public  void Add(ButacaObraCreateDTO butacaObraCreateDTO)
    {
        var seat = new ButacaObra();
        var mappedSeat = seat.mapFromCreateDto(butacaObraCreateDTO);
        _seatRepository.Add(mappedSeat);

            // foreach (var ingrediente in pizza.Ingredientes)
            // {
            //     _ingredientesRepository.AddIngredienteToPizza(ingrediente, pizza.Id);
            // }
    }

    public  void Update(int idFunction, int idSeat, ButacaObraUpdateDTO butacaObraUpdate)
    {
        // _seatRepository.Update(seat);
        var seatDto = _seatRepository.GetSeat(idFunction, idSeat);
            if (seatDto == null)
            {
                throw new KeyNotFoundException($"Seat with Id {idSeat} int function {idFunction} not found.");
            }

            // Mapea los datos del DTO a la entidad Obra
            var seat = seatDto.ToObra();
            seat.Libre = butacaObraUpdate.Libre;

            // Llama al método Update del repositorio con la entidad Obra actualizada
            _seatRepository.Update(seat);

            // _ingredientesRepository.UpdateIngredientesForPizza(pizza.Ingredientes, pizza.Id);
    }

    public  void Delete(int idFunction, int idSeat)
    {
        _seatRepository.Delete(idFunction, idSeat);
    }
}


        
    }

