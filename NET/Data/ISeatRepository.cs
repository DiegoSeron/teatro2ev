using Tickett.Models;
namespace Tickett.Data;

public interface ISeatRepository
{
    List<ButacaDTO> GetAll();
    // GetAll(int id);
    void Add(ButacaObra butaca);
    ButacaDTO GetSeat(int idFunction, int idSeat);
    List<ButacaDTO> GetFromFunction(int idFunction);
    void Update(ButacaObra butaca);
    void Delete(int idFunction, int idSeat);
}
