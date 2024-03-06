using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class ObraDTO
{
    [Required]
    public int ObraId { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public DateTime DiaObra { get; set; }

    [Required]
    public string Imagen { get; set; }
    [Required]
    public string Genero { get; set; }
    [Required]
    public int Duracion { get; set; }
    [Required]
    public decimal Precio { get; set; }

    public List<ButacaDTO> Butacas { get; set; }

    // public ObraCreateDTO(){
    //     ListaButacaObra = new List<ButacaObra>();
    // }

}