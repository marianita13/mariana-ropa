using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpresaConfiguration: IEntityTypeConfiguration<Empresa>
    {

        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasIndex(x => x.Nit)
            .IsUnique();
            builder.Property(x => x.RepresentanteLegal)
            .IsRequired();
            builder.Property(x => x.RazonSocial);
            
            builder.HasOne(j => j.Municipio)
            .WithMany(j => j.Empresas)
            .HasForeignKey(j => j.IdMunicipioFk);
        }
    }
}
