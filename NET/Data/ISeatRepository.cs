using Tickett.Models;
namespace Tickett.Data;

public interface ISeatRepository
{
    List<ButacaObra> GetAll();
    // GetAll(int id);
    void Add(ButacaObra butaca);
    ButacaObra GetSeat(int idFunction, int idSeat);
    List<ButacaObra> GetFromFunction(int idFunction);
    void Update(ButacaObra butaca);
    void Delete(int idFunction, int idSeat);
}
