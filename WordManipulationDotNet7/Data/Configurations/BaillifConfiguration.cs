using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class BaillifConfiguration : IEntityTypeConfiguration<Baillif>
    {
        public void Configure(EntityTypeBuilder<Baillif> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.AFM)
                .HasMaxLength(50);

            builder.HasIndex(b => b.Name);
        }
    }
}
