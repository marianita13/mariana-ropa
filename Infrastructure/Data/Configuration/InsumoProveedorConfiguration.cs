using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration: IEntityTypeConfiguration<InsumoProveedor>
    {

        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");
            builder.HasKey(t => new { t.IdInsumoFk, t.IdProveedorFk });

            builder.HasOne(j => j.Insumo)
            .WithMany(j => j.InsumoProveedores)
            .HasForeignKey(j => j.IdInsumoFk);

            builder.HasOne(j => j.Proveedor)
            .WithMany(j => j.InsumoProveedores)
            .HasForeignKey(j => j.IdProveedorFk);
        }
    }
}
