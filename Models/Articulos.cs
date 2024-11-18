using System.ComponentModel.DataAnnotations;

namespace FrailynGarcia_AP1_P2.Models;

public class Articulos
{
    [Key]

    public int ArticuloId { get; set; }

    [Required(ErrorMessage = "La Descripcion no puede estar en blanco")]

    public string Descripcion { get; set; }

    public double Costo { get; set; }

    public double Precio { get; set; }

    public int Existencia { get; set; }
}
