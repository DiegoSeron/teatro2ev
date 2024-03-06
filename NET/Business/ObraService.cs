using Tickett.Data;
using Tickett.Business;
using Tickett.Models;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;


namespace Tickett.Business
{
    public class ObraService : IObraService
    {

        private readonly IObraRepository _obraRepository;
        

        public ObraService(IObraRepository obraRepository){
            _obraRepository = obraRepository;
        
        }
        public  List<Obra> GetAll()
        {
            var obras = _obraRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return obras;
        }

        public  Obra Get(int id)
        {
            var obra = _obraRepository.Get(id);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return obra;
        }
          

        public Obra Add(ObraCreateDTO obraCreateDTO)
        {
            var obra = new Obra(titulo: obraCreateDTO.Titulo, descripcion: obraCreateDTO.Descripcion, diaObra: obraCreateDTO.DiaObra, imagen: obraCreateDTO.Imagen, genero: obraCreateDTO.Genero, duracion: obraCreateDTO.Duracion, precio: obraCreateDTO.Precio );
            _obraRepository.Add(obra);

            // foreach (var ingrediente in pizza.Ingredientes)
            // {
            //     _ingredientesRepository.AddIngredienteToPizza(ingrediente, pizza.Id);
            // }
    }

    public  void Update(Obra obra)
    {
        _obraRepository.Update(obra);

            // _ingredientesRepository.UpdateIngredientesForPizza(pizza.Ingredientes, pizza.Id);
    }

    public  void Delete(int id)
    {
        _obraRepository.Delete(id);
    }
}


        
    }

