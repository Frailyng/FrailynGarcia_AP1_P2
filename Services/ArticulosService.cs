using FrailynGarcia_AP1_P2.DAL;
using FrailynGarcia_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FrailynGarcia_AP1_P2.Services
{
    public class ArticulosService(IDbContextFactory<Contexto> DbFactory)
    {
        public async Task<List<ArticulosPC>> Listar(Expression<Func<ArticulosPC, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.ArticulosPC
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

    }
}
