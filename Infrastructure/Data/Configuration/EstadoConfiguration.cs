using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EstadoConfiguration: IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(x => x.Descripcion)
            .IsRequired();
            
            builder.HasOne(j => j.TipoEstado)
            .WithMany(j => j.Estados)
            .HasForeignKey(j => j.IdTipoEstadoFk);
        }
    }
}
