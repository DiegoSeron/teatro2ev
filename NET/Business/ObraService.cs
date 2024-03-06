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


        public ObraService(IObraRepository obraRepository)
        {
            _obraRepository = obraRepository;

        }

        public List<ButacaObra> CrearButacasObra(int obraId)
        {
            List<ButacaObra> butacas = new List<ButacaObra>();
            for (int i = 1; i <= 100; i++)
            {
                butacas.Add(new ButacaObra
                {
                    ButacaId = i,
                    ObraId = obraId,
                    Libre = true,
                });
            }

            return butacas;

        }

        public int Counter(){
            var counter = _obraRepository.GetAll().Count();

            return counter;
        }
        public List<Obra> GetAll()
        {
            var obras = _obraRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return obras;
        }

        public Obra Get(int id)
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
            // var obraConMayorId = _obraRepository.GetAll().OrderByDescending(o => o.ObraId).FirstOrDefault();
            // var obras = _obraRepository.GetAll();
            // var oId = obras.Count();
            var obra = new Obra(titulo: obraCreateDTO.Titulo, descripcion: obraCreateDTO.Descripcion, diaObra: obraCreateDTO.DiaObra, imagen: obraCreateDTO.Imagen, genero: obraCreateDTO.Genero, duracion: obraCreateDTO.Duracion, precio: obraCreateDTO.Precio);
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

