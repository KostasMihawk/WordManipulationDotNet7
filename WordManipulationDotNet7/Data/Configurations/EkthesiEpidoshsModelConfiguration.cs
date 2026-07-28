using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class EkthesiEpidoshsModelConfiguration : IEntityTypeConfiguration<EkthesiEpidoshsModel>
    {
        public void Configure(EntityTypeBuilder<EkthesiEpidoshsModel> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Perigrafh)
                .HasMaxLength(500);

            builder.Property(e => e.Kleisimo)
                .HasMaxLength(200);

            builder.Property(e => e.HasKleisimo)
                .IsRequired()
                .HasConversion<int>();

            builder.Property(e => e.Signature)
                .IsRequired()
                .HasConversion<int>();

            builder.HasIndex(e => e.PriorityNumber);
            builder.HasIndex(e => e.Name);
        }
    }
}
