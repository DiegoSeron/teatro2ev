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
    public string Reparto { get; set; }

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
    public Obra ToObra()
    {
        return new Obra
        {
            ObraId = this.ObraId,
            Titulo = this.Titulo,
            Descripcion = this.Descripcion,
            DiaObra = this.DiaObra,
            Imagen = this.Imagen,
            Reparto = this.Reparto,
            Genero = this.Genero,
            Duracion = this.Duracion,
            Precio = this.Precio,
            ListaButacaObra = this.Butacas != null ? this.Butacas.Select(b => new ButacaObra
            {
                Butaca = new Butaca { ButacaId = b.ButacaId, Libre = b.Libre }
            }).ToList() : null
        };
    }


}