using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleOrdenConfiguration: IEntityTypeConfiguration<DetalleOrden>
    {

        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(x => x.CantidadProducir);
            builder.Property(x => x.CantidadProducida);
            
            builder.HasOne(j => j.Orden)
            .WithMany(j => j.DetalleOrdenes)
            .HasForeignKey(j => j.IdOrdenFk);

            builder.HasOne(j => j.Prenda)
            .WithMany(j => j.DetalleOrdenes)
            .HasForeignKey(j => j.IdPrendaFk);

            builder.HasOne(j => j.Color)
            .WithMany(j => j.DetalleOrdenes)
            .HasForeignKey(j => j.IdColorFk);
            
            builder.HasOne(j => j.Estado)
            .WithMany(j => j.DetalleOrdenes)
            .HasForeignKey(j => j.IdEstadoFk);
        }
    }
}
