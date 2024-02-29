using Tickett.Models;

namespace Tickett.Business;
public interface IObraService
{
    List<Obra> GetAll();
    // GetAll(int id);
    public Obra Add(ObraCreateDTO obraCreateDTO);
    Obra Get(int id);
    void Update(int id, ObraUpdateDTO obraUpdateDTO);
    void Delete(int id);
}
