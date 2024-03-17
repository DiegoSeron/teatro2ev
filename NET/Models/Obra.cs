using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;

using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class Obra
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ObraId { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime DiaObra { get; set; }

    [Required]
    public string Imagen { get; set; }

    [Required]
    public string Reparto { get; set; }

    [Required]
    public string Genero { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public int Duracion { get; set; }
    [Required]
    public decimal Precio { get; set; }
    [Required]
    public List<ButacaObra> ListaButacaObra { get; set; }

    // public static int obraSeed = 1;

    public Obra() { }

    public Obra(string titulo, string title, string descripcion, string description, DateTime diaObra, string imagen, string reparto, string genero, string gender, int duracion, decimal precio)
    {
        Titulo = titulo;
        Title = title;
        Descripcion = descripcion;
        Description = description;
        DiaObra = diaObra;
        Imagen = imagen;
        Reparto = reparto;
        Genero = genero;
        Gender = gender;
        Duracion = duracion;
        Precio = precio;
        // ObraId = obraSeed;
        // obraSeed++;

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
            Title = obraCreateDTO.Title,
            Descripcion = obraCreateDTO.Descripcion,
            Description = obraCreateDTO.Description,
            DiaObra = obraCreateDTO.DiaObra,
            Imagen = obraCreateDTO.Imagen,
            Reparto = obraCreateDTO.Reparto,
            Genero = obraCreateDTO.Genero,
            Gender = obraCreateDTO.Gender,
            Duracion = obraCreateDTO.Duracion,
            Precio = obraCreateDTO.Precio,
            // Resto de las propiedades...
        };

        return obra;
    }

    public ObraDTO MapToDTO()
    {
        var obraDto = new ObraDTO
        {
            ObraId = this.ObraId,
            Titulo = this.Titulo,
            Title = this.Title,
            Descripcion = this.Descripcion,
            Description = this.Description,
            DiaObra = this.DiaObra,
            Imagen = this.Imagen,
            Reparto = this.Reparto,
            Genero = this.Genero,
            Gender = this.Gender,
            Duracion = this.Duracion,
            Precio = this.Precio,
            Butacas = this.ListaButacaObra.Select(bo => new ButacaDTO
            {
                ButacaId = bo.Butaca.ButacaId,
                Libre = bo.Butaca.Libre
            }).ToList()
        };

        return obraDto;
    }
}



