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
        public List<ObraDTO> GetAll()
        {
            var obras = _obraRepository.GetAll();
            return obras;
        }


        public ObraDTO Get(int id)
        {
            var obra = _obraRepository.Get(id);
            // Aquí deberías mapear la instancia de Obra a ObraDTO si es necesario
            return obra;
        }


        public void Add(ObraCreateDTO obraCreateDTO)
        {

            var obra = new Obra();
            var mappedObra = obra.mapFromCreateDto(obraCreateDTO);
            _obraRepository.Add(mappedObra);

        }

        public void Update(int id, ObraUpdateDTO obraUpdate)
        {
            var obraDto = _obraRepository.Get(id);
            if (obraDto == null)
            {
                throw new KeyNotFoundException($"Obra con Id {id} no encontrada.");
            }

            // Mapea los datos del DTO a la entidad Obra
            var obra = obraDto.ToObra();
            obra.Titulo = obraUpdate.Titulo;
            obra.Descripcion = obraUpdate.Descripcion;
            obra.Precio = obraUpdate.Precio;
            obra.DiaObra = obraUpdate.DiaObra;

            // Llama al método Update del repositorio con la entidad Obra actualizada
            _obraRepository.Update(obra);
        }



        public void Delete(int id)
        {
            _obraRepository.Delete(id);
        }
    }




}

