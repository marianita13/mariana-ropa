using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenConfiguration: IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(x => x.Fecha);

            builder.HasOne(j => j.Empleado)
            .WithMany(j => j.Ordenes)
            .HasForeignKey(j => j.IdEmpleadoFk);

            builder.HasOne(j => j.Cliente)
            .WithMany(j => j.Ordenes)
            .HasForeignKey(j => j.IdClienteFk);

            builder.HasOne(j => j.Estado)
            .WithMany(j => j.Ordenes)
            .HasForeignKey(j => j.IdEstadoFk);
        }
    }
}
