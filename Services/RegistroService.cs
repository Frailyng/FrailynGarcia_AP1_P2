using FrailynGarcia_AP1_P2.DAL;
using FrailynGarcia_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrailynGarcia_AP1_P2.Services;

public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int registroId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return true;
    }

    public async Task<bool> Insertar(Registros registro)
    {
        return true;
    }

    public async Task AfectarRegistros(CombosDetalle[] detalle)
    {

    }

    public async Task<bool> Modificar(Registros registro)
    {
        return true;
    }


    public async Task<bool> Guardar(Registros registro)
    {
        return true;
    }

    //Funcion Buscar

    public async Task<bool> Eliminar(int id)
    {
        return true;
    }

    // Funcion Listar
}
