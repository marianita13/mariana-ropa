using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProveedorConfiguration: IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasIndex(x => x.NitProveedor)
            .IsUnique();
            builder.Property(x => x.Nombre)
            .IsRequired();

            builder.HasOne(j => j.TipoPersona)
            .WithMany(j => j.Proveedores)
            .HasForeignKey(j => j.IdTipoPersonaFk);

            builder.HasOne(j => j.Municipio)
            .WithMany(j => j.Proveedores)
            .HasForeignKey(j => j.IdMunicipioFk);

        }
    }
}
