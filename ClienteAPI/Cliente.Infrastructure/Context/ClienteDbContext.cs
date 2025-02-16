using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Infrastructure.Context;

public class ClienteDbContext(DbContextOptions<ClienteDbContext> options) : DbContext(options)
{
    public DbSet<Cliente> Clientes { get; set; }

}