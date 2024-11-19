using FrailynGarcia_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrailynGarcia_AP1_P2.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Combos> Combos { get; set; }

        public DbSet<CombosDetalle> CombosDetalle { get; set; }

        public DbSet<ArticulosPCs> ArticulosPC { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticulosPCs>().HasData(new List<ArticulosPCs>()
            {
                new ArticulosPCs() {ArticuloId = 1, Descripcion = "Monitor", Costo = 700, Precio = 1400, Existencia = 50},
                new ArticulosPCs() { ArticuloId = 2, Descripcion = "Mouse", Costo = 120, Precio = 500, Existencia = 100},
                new ArticulosPCs() { ArticuloId = 3, Descripcion = "Teclado", Costo = 300, Precio = 1500, Existencia = 70},
                new ArticulosPCs() {ArticuloId = 4, Descripcion = "CPU", Costo = 700, Precio = 1700, Existencia = 50},
                new ArticulosPCs() {ArticuloId = 5, Descripcion = "Memoria Ram", Costo = 350, Precio = 1300, Existencia = 40 }

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
