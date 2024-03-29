using Tickett.Models;
namespace Tickett.Business;

public interface IUserRepository
{
    List<UserDTO> GetAll();
    // GetAll(int id);
    void Add(User user);
    UserDTO Get(int id);
    void Update(User user);
    void Delete(int id);
}
