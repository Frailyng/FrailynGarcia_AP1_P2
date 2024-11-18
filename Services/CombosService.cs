using FrailynGarcia_AP1_P2.DAL;
using FrailynGarcia_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FrailynGarcia_AP1_P2.Services;

public class CombosService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int comboId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos.AnyAsync(t => t.ComboId == comboId);
    }

    public async Task<bool> Insertar(Combos combo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Combos.Add(combo);
        await AfectarCombos(combo.CombosDetalle.ToArray());
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task AfectarCombos(CombosDetalle[] detalle)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        foreach (var item in detalle)
        {
            var articulo = await contexto.ArticulosPC.SingleAsync(t => t.ArticuloId == item.ArticuloId);
        }
    }

    public async Task<bool> Modificar(Combos combo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Update(combo);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Combos combo)
    {
        if (!await Existe(combo.ComboId))
        {
            return await Insertar(combo);
        }
        else
        {
            return await Modificar(combo);
        }
    }

    public async Task<Combos> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos
            .Include(t => t.CombosDetalle)
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.ComboId == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos
            .Include(t => t.CombosDetalle)
            .Where(t => t.ComboId == id)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Combos>> Listar(Expression<Func<Combos, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos
            .Include(t => t.CombosDetalle)
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}

