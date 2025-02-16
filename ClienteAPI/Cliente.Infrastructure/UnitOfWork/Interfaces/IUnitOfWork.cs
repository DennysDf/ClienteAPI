using ClienteAPI.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Infrastructure.UnitOfWork.Interfaces;

public interface IUnitOfWork
{
    IClienteRepository ClienteRepository { get; }
    Task<int> SaveChangesAsync();
}