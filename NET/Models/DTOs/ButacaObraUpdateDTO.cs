using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class ButacaObraUpdateDTO
{
    [Required]
    public bool Libre { get; set; }

}