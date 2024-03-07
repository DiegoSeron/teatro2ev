using Tickett.Models;

namespace Tickett.Business
{
    public interface IObraService
    {
        List<Obra> GetAll();
        // GetAll(int id);
        void Add(ObraCreateDTO obraCreateDTO);
        ObraDTO Get(int id); // Cambiado a ObraDTO
        void Update(int id, ObraUpdateDTO obraUpdateDTO);
        void Delete(int id);
    }
}

