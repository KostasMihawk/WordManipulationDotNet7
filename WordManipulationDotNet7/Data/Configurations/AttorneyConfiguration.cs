using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class AttorneyConfiguration : IEntityTypeConfiguration<Attorney>
    {
        public void Configure(EntityTypeBuilder<Attorney> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Pronoun)
                .HasMaxLength(50);

            builder.Property(a => a.Description)
                .HasMaxLength(1000);

            builder.Property(a => a.GiaSunexisi)
                .HasMaxLength(1000);

            builder.HasIndex(a => a.Name);
        }
    }
}
