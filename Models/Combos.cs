﻿using System.ComponentModel.DataAnnotations;

namespace FrailynGarcia_AP1_P2.Models
{
    public class Combos
    {
        [Key]
        public int ComboId { get; set; }

        public DateTime Fecha {  get; set; }

        [Required(ErrorMessage = "La descripcion no puede estar en blanco")]

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public bool Vendido { get; set; }

        public ICollection<CombosDetalle> CombosDetalle { get; set; } = new List<CombosDetalle>();
    }
}
