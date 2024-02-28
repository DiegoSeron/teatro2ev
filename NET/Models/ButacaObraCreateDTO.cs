using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;

using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class ButacaObraCreateDTO
{
    [ForeignKey("Obra")]
    public int ObraId { get; set; }

}