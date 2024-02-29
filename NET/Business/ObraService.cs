using Tickett.Data;
using Tickett.Business;
using Tickett.Models;


namespace Tickett.Business
{
    public class ObraService : IObraService
    {

        private readonly IObraRepository _obraRepository;


        public ObraService(IObraRepository obraRepository)
        {
            _obraRepository = obraRepository;

        }
        public List<Obra> GetAll()
        {
            var pizzas = _obraRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return pizzas;
        }

        public Obra Get(int id)
        {
            var pizza = _obraRepository.Get(id);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return pizza;
        }


        public Obra Add(ObraCreateDTO obraCreateDTO)
        {
            var obra = new Obra(titulo: obraCreateDTO.Titulo, descripcion: obraCreateDTO.Descripcion, diaObra: obraCreateDTO.DiaObra, imagen: obraCreateDTO.Imagen, genero: obraCreateDTO.Genero, duracion: obraCreateDTO.Duracion, precio: obraCreateDTO.Precio );
            _obraRepository.Add(obra);

            return obra;

        }

        public void Update(int id, ObraUpdateDTO obraDto)
        {
            var obra = _obraRepository.Get(id);
            if (obra == null)
            {
                throw new KeyNotFoundException($"Obra with number {id} not found.");
            }

            obra.Titulo = obraDto.Titulo;
            obra.Descripcion = obraDto.Descripcion;
            obra.Precio = obraDto.Precio;
            obra.DiaObra = obraDto.DiaObra;
            _obraRepository.Update(obra);

            // _ingredientesRepository.UpdateIngredientesForPizza(pizza.Ingredientes, pizza.Id);
        }

        public void Delete(int id)
        {
            _obraRepository.Delete(id);
        }

    }



}

