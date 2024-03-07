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


    public Obra mapFromCreateDto(ObraCreateDTO obraCreateDTO)
    {
        if (obraCreateDTO == null)
        {
            // Puedes lanzar una excepción aquí o manejar el caso de DTO nulo según tu lógica
            throw new ArgumentNullException(nameof(obraCreateDTO));
        }

        var obra = new Obra
        {
            Titulo = obraCreateDTO.Titulo,
            Descripcion = obraCreateDTO.Descripcion,
            DiaObra = obraCreateDTO.DiaObra,
            Imagen = obraCreateDTO.Imagen,
            Genero = obraCreateDTO.Genero,
            Duracion = obraCreateDTO.Duracion,
            Precio = obraCreateDTO.Precio,
            // Resto de las propiedades...
        };

        return obra;
    }

    public ObraDTO MapToDTO(Obra obra)
    {
        if (obra == null)
        {
            return null; // Devolver nulo si la obra es nula
        }

        var obraDto = new ObraDTO
        {
            ObraId = obra.ObraId,
            Titulo = obra.Titulo,
            Descripcion = obra.Descripcion,
            DiaObra = obra.DiaObra,
            Imagen = obra.Imagen,
            Genero = obra.Genero,
            Duracion = obra.Duracion,
            Precio = obra.Precio,
            Butacas = this.ListaButacaObra.Select(bo => new ButacaDTO
            {
                ButacaId = bo.Butaca.ButacaId,
                Libre = bo.Butaca.Libre
            }).ToList()
            // Agrega otras propiedades si es necesario
        };

        return obraDto;
    }

}

