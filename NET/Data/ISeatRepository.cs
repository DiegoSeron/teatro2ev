using Tickett.Models;
namespace Tickett.Data;

public interface ISeatRepository
{
    List<ButacaObra> GetAll();
    // GetAll(int id);
    void Add(ButacaObra butaca);
    ButacaObra Get(int idFunction, int idSeat);
    void Update(ButacaObra butaca);
    void Delete(int idFunction, int idSeat);
}
