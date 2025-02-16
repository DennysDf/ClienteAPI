using ClienteAPI.Infrastructure.UnitOfWork.Interfaces;
using ClienteAPI.Infrastructure.Context;
using ClienteAPI.Infrastructure.Repositories;
using ClienteAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IClienteRepository _clienteRepository;

        public ClienteDbContext _context;

        public UnitOfWork(ClienteDbContext context)
        {
            _context = context;
        }

        //garante que a instancia será criada apenas quando for chamada.
        //verifica se existe alguma instancia de cliente pronta
        public IClienteRepository ClienteRepository 
        {
            get 
            {
                return _clienteRepository = _clienteRepository ?? new ClienteRepository(_context);
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
