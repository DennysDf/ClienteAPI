using ClienteAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Infrastructure.Mappers;

public class ClienteMapper : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(c => c.CreatedDate)
              .HasDefaultValue(DateTime.Now);

        builder.Property(c => c.Active)
            .HasDefaultValue(true);

        builder.Property(x => x.UpdatedDate)
            .IsRequired(false);

        builder.Property(x => x.Active)
            .IsRequired();

        builder.Property(x => x.Nome)
            .IsRequired();

        builder.Property(x => x.NomeMae)
            .IsRequired();

        builder.Property(x => x.Idade)
            .IsRequired();

        builder.Property(x => x.Endereco)
            .IsRequired();

        builder.Property(x => x.Sexo)
            .IsRequired(false);

        builder.Property(x => x.EstadoCivil)
            .IsRequired(false);

    }    
}
