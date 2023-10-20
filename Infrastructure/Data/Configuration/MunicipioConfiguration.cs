using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class MunicipioConfiguration: IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(x => x.Nombre)
            .IsRequired();

            builder.HasOne(j => j.Departamento)
            .WithMany(j => j.Municipios)
            .HasForeignKey(j => j.IdDepartamentoFk);
        }
    }
}
