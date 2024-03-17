using Tickett.Models;

namespace Tickett.Business
{
    public interface IObraService
    {
        List<ObraDTO> GetAll();
        // GetAll(int id);
        void Add(ObraCreateDTO obraCreateDTO);
        ObraDTO Get(int id); // Cambiado a ObraDTO
        void Update(int id, ObraUpdateDTO obraUpdateDTO);
        void Delete(int id);
    }
}

