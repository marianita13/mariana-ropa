using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteConfiguration: IEntityTypeConfiguration<Cliente>
    {

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasIndex(x => x.IdCliente)
            .IsUnique();
            builder.Property(x => x.Nombre)
            .IsRequired();
            builder.Property(x => x.FechaRegistro);
            
            builder.HasOne(j => j.TipoPersona)
            .WithMany(j => j.Clientes)
            .HasForeignKey(j => j.IdTipoPersonaFk);

            builder.HasOne(j => j.Municipio)
            .WithMany(j => j.Clientes)
            .HasForeignKey(j => j.IdMunicipioFk);
        }
    }
}
