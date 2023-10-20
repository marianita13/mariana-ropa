using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioTallaConfiguration: IEntityTypeConfiguration<InventarioTalla>
    {

        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

            builder.Property(x => x.Cantidad)
            .IsRequired();

            builder.HasKey(t => new { t.IdTallaFk, t.IdInventarioFk });
        
            builder.HasOne(j => j.Inventario)
            .WithMany(j => j.InventarioTallas)
            .HasForeignKey(j => j.IdInventarioFk);

            builder.HasOne(j => j.Talla)
            .WithMany(j => j.InventarioTallas)
            .HasForeignKey(j => j.IdTallaFk);
        }
    }
}
