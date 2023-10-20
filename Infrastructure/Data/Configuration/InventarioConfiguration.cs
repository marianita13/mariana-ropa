using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration: IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasIndex(x => x.CodInv)
            .IsUnique();
            builder.Property(x => x.ValorVtaCop);
            builder.Property(x => x.ValorVtaUsd);

            builder.HasOne(j => j.Prenda)
            .WithMany(j => j.Inventarios)
            .HasForeignKey(j => j.IdPrendaFk);
        }
    }
}
