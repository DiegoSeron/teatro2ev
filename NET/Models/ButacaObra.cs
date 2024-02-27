namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class ButacaObra
{
    [Key]
    public int Butaca_obraId { get; set; }
    [Required]
    public bool Libre { get; set; }

    [ForeignKey ("Obra")]
    public int ObraId { get; set;}
    public Obra Obra { get; set; }
    
    [ForeignKey ("Butaca")]
     public int ButacaId { get; set; }

    public Butaca Butaca { get; set; }
    
    public ButacaObra() { }
    public ButacaObra(int butacaId, bool libre, int obraId)
    {
        Libre = libre;
        ButacaId = butacaId;
        ObraId = obraId;
        //     ButacaId = butacaSeed;
        //     butacaSeed++;
        // 
    }

    
}