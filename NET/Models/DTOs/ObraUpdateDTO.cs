using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class ObraUpdateDTO
{
     [Required]
    public string Titulo { get; set; }
     [Required]
    public string Title { get; set; }
    
     [Required]
    public string Descripcion { get; set; }
     [Required]
    public string Description { get; set; }
     [Required]
    public int Precio { get; set; }
     [Required]
    public DateTime DiaObra { get; set; }

}