namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class Butaca
{
    [Key]
    public int ButacaId { get; set; }
    public bool Libre { get; set; }
    public List<ButacaObra> ListaButacaObra { get; set; }

    public Butaca() { }
    public Butaca(int butacaId, bool libre)
    {
        ButacaId = butacaId;
        //     ButacaId = butacaSeed;
        //     butacaSeed++;
        // 
    }

    
}