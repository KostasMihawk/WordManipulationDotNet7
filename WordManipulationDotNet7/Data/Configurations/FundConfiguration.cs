using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class FundConfiguration : IEntityTypeConfiguration<Fund>
    {
        public void Configure(EntityTypeBuilder<Fund> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(f => f.Description)
                .HasMaxLength(500);

            builder.Property(f => f.MAEDAP)
                .HasMaxLength(100);

            builder.Property(f => f.MAEDAPAdress)
                .HasMaxLength(300);

            builder.HasIndex(f => f.Name);
        }
    }
}
