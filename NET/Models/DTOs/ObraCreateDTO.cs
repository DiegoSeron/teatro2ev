using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class ObraCreateDTO
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
    public DateTime DiaObra { get; set; }

    [Required]
    public string Imagen { get; set; }

    [Required]
    public string Reparto { get; set; }

    [Required]
    public string Genero { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public int Duracion { get; set; }
    [Required]
    public decimal Precio { get; set; }

}
