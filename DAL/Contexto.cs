using FrailynGarcia_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrailynGarcia_AP1_P2.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Registros> Registros { get; set; }

        public DbSet<RegistrosDetalle> RegistrosDetalle { get; set; }

        public DbSet<Articulos> Articulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>().HasData(new List<Articulos>()
            {
                new Articulos() {ArticuloId = 1, Descripcion = "Monitor", Costo = 700, Precio = 1400, Existencia = 50},
                new Articulos() { ArticuloId = 2, Descripcion = "Mouse", Costo = 120, Precio = 500, Existencia = 100},
                new Articulos() { ArticuloId = 3, Descripcion = "Teclado", Costo = 300, Precio = 1500, Existencia = 70},
                new Articulos() {ArticuloId = 4, Descripcion = "CPU", Costo = 700, Precio = 1700, Existencia = 50}

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
