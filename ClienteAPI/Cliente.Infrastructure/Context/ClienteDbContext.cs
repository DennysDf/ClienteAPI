using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ClienteAPI.Domain.Models;
namespace ClienteAPI.Infrastructure.Context;

public class ClienteDbContext : IdentityDbContext<ApplicationUser>
{
    public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options){    }

    public DbSet<Domain.Models.Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
      
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClienteDbContext).Assembly);
    }
}