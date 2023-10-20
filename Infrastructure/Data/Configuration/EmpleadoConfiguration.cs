using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration: IEntityTypeConfiguration<Empleado>
    {

        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasIndex(x => x.IdEmp)
            .IsUnique();
            builder.Property(x => x.Nombre)
            .IsRequired();
            builder.Property(x => x.FechaIngreso);
            
            builder.HasOne(j => j.Cargo)
            .WithMany(j => j.Empleados)
            .HasForeignKey(j => j.IdCargoFk);

            builder.HasOne(j => j.Municipio)
            .WithMany(j => j.Empleados)
            .HasForeignKey(j => j.IdMunicipioFk);

        }
    }
}
