using FrailynGarcia_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrailynGarcia_AP1_P2.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Registros> Registros { get; set; }

        public DbSet<RegistrosDetalle> RegistrosDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registros>().HasData(new List<Registros>()
            {

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
