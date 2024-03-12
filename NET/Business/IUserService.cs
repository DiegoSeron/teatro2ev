using System.Data.Common;
using Tickett.Models;
namespace Tickett.Business;

public interface IUserService
{
    List<UserDTO> GetAll();
    // GetAll(int id);
    void Add(UserCreateDTO userCreateDTO);
    UserDTO Get(int id);
    void Update(int id, UserUpdateDTO userUpdateDTO);
    void Delete(int id);
}
