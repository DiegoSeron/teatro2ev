using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class Obra
{
    [Key]
    public int ObraId { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public DateTime DiaObra { get; set; }

    [Required]
    public string Imagen { get; set; }
    public List<ObraReparto> ListaObraReparto { get; set; }
    [Required]
    public string Genero { get; set; }
    [Required]
    public int Duracion { get; set; }
    [Required]
    public decimal Precio { get; set; }
    [Required]
    public List<ButacaObra> ListaButacaObra { get; set; }

    public static int obraSeed = 1;

    public Obra() { }

    public Obra(string titulo, string descripcion, DateTime diaObra, string imagen, string genero, int duracion, decimal precio)
    {
        Titulo = titulo;
        Descripcion = descripcion;
        DiaObra = diaObra;
        Imagen = imagen;
        Genero = genero;
        Duracion = duracion;
        Precio = precio;
        ObraId = obraSeed;
        obraSeed++;

    }

}