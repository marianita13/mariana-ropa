using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleVentaConfiguration: IEntityTypeConfiguration<DetalleVenta>
    {

        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(x => x.Cantidad)
            .IsRequired();
            builder.Property(x => x.ValorUnit);
            
            builder.HasOne(j => j.Venta)
            .WithMany(j => j.DetalleVentas)
            .HasForeignKey(j => j.IdVentaFk);

            builder.HasOne(j => j.Inventario)
            .WithMany(j => j.DetalleVentas)
            .HasForeignKey(j => j.IdProductoFk);

            builder.HasOne(j => j.Talla)
            .WithMany(j => j.DetalleVentas)
            .HasForeignKey(j => j.IdTallaFk);
        }
    }
}
