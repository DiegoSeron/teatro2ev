using Tickett.Models;
namespace Tickett.Business;

public interface ISeatService
{
    List<ButacaDTO> GetAll();
    // GetAll(int id);
    void Add(ButacaObraCreateDTO butacaObraCreateDTO);
    ButacaDTO GetSeat(int idFunction, int idSeat);
    List<ButacaDTO> GetFromFunction(int idFunction);
    void Update(int idFunction, int idSeat, ButacaObraUpdateDTO butacaObraUpdateDTO);
    void Delete(int idFunction, int idSeat);
}
