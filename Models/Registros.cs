using System.ComponentModel.DataAnnotations;

namespace FrailynGarcia_AP1_P2.Models
{
    public class Registros
    {
        [Key]
        public int RegistroId { get; set; }

        public ICollection<RegistrosDetalle> RegistrosDetalles { get; set; } = new List<RegistrosDetalle>();
    }
}
