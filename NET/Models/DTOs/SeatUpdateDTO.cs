using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tickett.Models;
using System.Text;
public class SeatUpdateDTO
{
    public bool Libre { get; set; }

    public int ObraId { get; set; }

    public int ButacaId { get; set; }
}