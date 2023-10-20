using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(x => x.Descripcion);
            builder.Property(x => x.SueldoBase)
            .IsRequired();
            
        }
    }
}
