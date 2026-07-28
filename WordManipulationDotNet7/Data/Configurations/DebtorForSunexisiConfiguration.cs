using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class DebtorForSunexisiConfiguration : IEntityTypeConfiguration<DebtorForSunexisi>
    {
        public void Configure(EntityTypeBuilder<DebtorForSunexisi> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(d => d.Description)
                .HasMaxLength(1000);

            builder.HasIndex(d => d.Name);
        }
    }
}
