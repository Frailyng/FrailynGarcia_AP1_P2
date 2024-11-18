using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrailynGarcia_AP1_P2.Models
{
    public class CombosDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        public int ComboId { get; set; }

        public int ArticuloId { get; set; }

        public int Cantidad {  get; set; }

        public double Costo { get; set; }

        public double Precio { get; set; }

        public double Monto { get; set; }

        [ForeignKey("ComboId")]
        public virtual Combos Combos { get; set; } = null!;
    }
}
