using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DepartamentoConfiguration: IEntityTypeConfiguration<Departamento>
    {

        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamento");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(x => x.Nombre)
            .IsRequired();
            
            builder.HasOne(j => j.Pais)
            .WithMany(j => j.Departamentos)
            .HasForeignKey(j => j.IdPaisFk);
        }
    }
}
