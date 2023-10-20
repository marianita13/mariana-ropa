using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration: IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");
            
            builder.HasIndex(x => x.Cantidad);
            builder.HasKey(t => new { t.IdInsumoFk, t.IdPrendaFk });

            builder.HasOne(j => j.Insumo)
            .WithMany(j => j.InsumoPrendas)
            .HasForeignKey(j => j.IdInsumoFk);

            builder.HasOne(j => j.Prenda)
            .WithMany(j => j.InsumoPrendas)
            .HasForeignKey(j => j.IdPrendaFk);
        }
    }
}
