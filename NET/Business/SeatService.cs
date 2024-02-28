using Tickett.Data;
using Tickett.Business;
using Tickett.Models;


namespace Tickett.Business
{
    public class SeatService : ISeatService
    {

        private readonly ISeatRepository _seatRepository;
        

        public SeatService(ISeatRepository seatRepository){
            _seatRepository = seatRepository;
        
        }
        public  List<ButacaObra> GetAll()
        {
            var seats = _seatRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return seats;
        }

        public  ButacaObra GetSeat(int idFunction, int idSeat)
        {
            var seat = _seatRepository.GetSeat(idFunction, idSeat);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return seat;
        }

        public  List<ButacaObra> GetFromFunction(int idFunction)
        {
            var seat = _seatRepository.GetFromFunction(idFunction);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return seat;
        }
          

    public  void Add(ButacaObra seat)
    {
        _seatRepository.Add(seat);

            // foreach (var ingrediente in pizza.Ingredientes)
            // {
            //     _ingredientesRepository.AddIngredienteToPizza(ingrediente, pizza.Id);
            // }
    }

    public  void Update(ButacaObra seat)
    {
        _seatRepository.Update(seat);

            // _ingredientesRepository.UpdateIngredientesForPizza(pizza.Ingredientes, pizza.Id);
    }

    public  void Delete(int idFunction, int idSeat)
    {
        _seatRepository.Delete(idFunction, idSeat);
    }
}


        
    }

