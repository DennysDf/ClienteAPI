using ClienteAPI.Domain.Models;
using ClienteAPI.Infrastructure.Context;
using ClienteAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ClienteDbContext _context;

    public ClienteRepository(ClienteDbContext context)
    {
        _context = context;
    }

    public async Task<Cliente> CreateAsync(Cliente cliente)
    {
        _context.Add(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }

    public async Task<Cliente> GetByIdAsync(int? id)
    {        
        return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Cliente>> GetClientesAsync()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente> RemoveAsync(Cliente cliente)
    {
        _context.Remove(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }

    public async Task<Cliente> UpdateAsync(Cliente cliente)
    {
        _context.Update(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }
}
