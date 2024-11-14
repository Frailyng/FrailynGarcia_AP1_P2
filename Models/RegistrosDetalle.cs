using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrailynGarcia_AP1_P2.Models
{
    public class RegistrosDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        public int RegistroId { get; set; }

        [ForeignKey("RegistroId")]
        public virtual Registros Registros { get; set; } = null!;
    }
}
