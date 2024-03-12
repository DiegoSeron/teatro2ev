using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class UserDTO
{
    [Required]
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Password {get; set;}

    // public ObraCreateDTO(){
    //     ListaButacaObra = new List<ButacaObra>();
    // }
    public User ToUser()
    {
        return new User
        {
            UserId = this.UserId,
            Name = this.Name,
            Password = this.Password
        };
    }
}