using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class ZoneConfiguration : IEntityTypeConfiguration<Zone>
    {
        public void Configure(EntityTypeBuilder<Zone> builder)
        {
            builder.HasKey(z => z.Id);

            builder.Property(z => z.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(z => z.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(z => z.Tax)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(z => z.TaxedValue)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.HasIndex(z => z.Name);
        }
    }
}
