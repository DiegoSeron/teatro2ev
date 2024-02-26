namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class Butaca
{
    [Key]
    public int ButacaId { get; set; }
    [Required]
    public bool Libre { get; set; }
    [Required]
    public int ObraId { get; set; }
    public Obra Obra { get; set; }

    
    public Butaca() { }
    public Butaca(int butacaId, bool libre, int obraId)
    {
        Libre = libre;
        ObraId = obraId;
        ButacaId = butacaId;
        //     ButacaId = butacaSeed;
        //     butacaSeed++;
        // 
    }

    
}
