namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class ButacaObra
{

    // [Key]
    // public int SesionId;

    [ForeignKey ("Obra")]
    public int ObraId { get; set;}
    
    [ForeignKey ("Butaca")]
     public int ButacaId { get; set; }
    public Obra Obra { get; set; }
    [Required]
    public bool Libre { get; set; }
    public Butaca Butaca { get; set; }
    
    public ButacaObra() { }
    public ButacaObra(int butacaId, bool libre, int obraId, int sesionId)
    {
        Libre = libre;
        ButacaId = butacaId;
        ObraId = obraId;
        // SesionId = sesionId;
        //     ButacaId = butacaSeed;
        //     butacaSeed++;
        // 
    }

    public ButacaObra mapFromCreateDto(ButacaObraCreateDTO butacaObraCreateDTO)
    {
        if (butacaObraCreateDTO == null)
        {
            // Puedes lanzar una excepción aquí o manejar el caso de DTO nulo según tu lógica
            throw new ArgumentNullException(nameof(butacaObraCreateDTO));
        }

        var butacaObra = new ButacaObra
        {
            ObraId = butacaObraCreateDTO.ObraId,
            ButacaId = butacaObraCreateDTO.ButacaId,
            // Resto de las propiedades...
        };

        return butacaObra;
    }
    
}