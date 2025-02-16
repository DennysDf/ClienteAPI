using Microsoft.EntityFrameworkCore;
namespace ClienteAPI.Infrastructure.Context;

public class ClienteDbContext(DbContextOptions<ClienteDbContext> options) : DbContext(options)
{
    public DbSet<Domain.Models.Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClienteDbContext).Assembly);
    }
}