using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class VentaConfiguration: IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(x => x.FechaCreacion)
            .IsRequired();

            builder.HasOne(j => j.Empleado)
            .WithMany(j => j.Ventas)
            .HasForeignKey(j => j.IdEmpleadoFk);

            builder.HasOne(j => j.Cliente)
            .WithMany(j => j.Ventas)
            .HasForeignKey(j => j.IdClienteFk);

            builder.HasOne(j => j.FormaPago)
            .WithMany(j => j.Ventas)
            .HasForeignKey(j => j.IdFormaPagoFk);
        }
    }
}