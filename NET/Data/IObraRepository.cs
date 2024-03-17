using Tickett.Models;


public interface IObraRepository
{
    List<ObraDTO> GetAll();
    // GetAll(int id);
    void Add(Obra obra);
    ObraDTO Get(int id);
    void Update(Obra obra);
    void Delete(int id);
}
