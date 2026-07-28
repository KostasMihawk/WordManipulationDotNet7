using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<PistotikaIdrymataUpoEkkatharisi>
    {
        public void Configure(EntityTypeBuilder<PistotikaIdrymataUpoEkkatharisi> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.DiakritikosTitlos)
                .HasMaxLength(200);

            builder.Property(b => b.Edra)
                .HasMaxLength(300);

            builder.Property(b => b.AFM)
                .HasMaxLength(50);

            builder.HasIndex(b => b.Name);
        }
    }
}
