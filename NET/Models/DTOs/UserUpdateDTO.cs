using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class UserUpdateDTO
{
    [Required]
    public string Name { get; set; }
    public string Password {get; set;}
    public string Email {get; set;}

    // public ObraCreateDTO(){
    //     ListaButacaObra = new List<ButacaObra>();
    // }
}