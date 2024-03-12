using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class ButacaDTO
{
    [Required]
    public int ButacaId { get; set; }
    public int ObraId { get; set; }
    
    public bool Libre {get; set;}

    // public ObraCreateDTO(){
    //     ListaButacaObra = new List<ButacaObra>();
    // }
    public ButacaObra ToObra()
    {
        return new ButacaObra
        {
            ObraId = this.ObraId,
            ButacaId = this.ButacaId,
            Libre = this.Libre
        };
    }
}