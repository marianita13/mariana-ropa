using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PrendaConfiguration: IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasIndex(x => x.IdPrenda)
            .IsUnique();
            builder.Property(x => x.Nombre)
            .IsRequired();
            builder.Property(x => x.ValorUnitUsd);
            builder.Property(x => x.ValorUnitCop);

            builder.HasOne(j => j.Estado)
            .WithMany(j => j.Prendas)
            .HasForeignKey(j => j.IdEstadoFk);

            builder.HasOne(j => j.TipoProteccion)
            .WithMany(j => j.Prendas)
            .HasForeignKey(j => j.IdTipoProteccionFk);

            builder.HasOne(j => j.Genero)
            .WithMany(j => j.Prendas)
            .HasForeignKey(j => j.IdGeneroFk);
        }
    }
}
