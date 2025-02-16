using ClienteAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Infrastructure.Repositories.Interfaces;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> GetClientesAsync();
    Task<Cliente> GetByIdAsync(int? id);
    Task<Cliente> CreateAsync(Cliente product);
    Task<Cliente> UpdateAsync(Cliente product);
    Task<Cliente> RemoveAsync(Cliente product);
}
