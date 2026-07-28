using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data
{
    public class BaillifConfiguration : IEntityTypeConfiguration<Baillif>
    {
        public void Configure(EntityTypeBuilder<Baillif> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.Property(b => b.City).HasMaxLength(100);
            builder.Property(b => b.AFM).HasMaxLength(50);
        }
    }

    public class AttorneyConfiguration : IEntityTypeConfiguration<Attorney>
    {
        public void Configure(EntityTypeBuilder<Attorney> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
            builder.Property(a => a.City).HasMaxLength(100);
            builder.Property(a => a.Pronoun).HasMaxLength(50);
            builder.Property(a => a.Description).HasMaxLength(2000);
            builder.Property(a => a.GiaSunexisi).HasMaxLength(2000);
        }
    }

    public class FundConfiguration : IEntityTypeConfiguration<Fund>
    {
        public void Configure(EntityTypeBuilder<Fund> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).IsRequired().HasMaxLength(300);
            builder.Property(f => f.Description).HasMaxLength(500);
            builder.Property(f => f.MAEDAP).HasMaxLength(500);
            builder.Property(f => f.MAEDAPAdress).HasMaxLength(500);
        }
    }

    public class ZoneConfiguration : IEntityTypeConfiguration<Zone>
    {
        public void Configure(EntityTypeBuilder<Zone> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.Name).IsRequired().HasMaxLength(10);
            builder.Property(z => z.Value).HasPrecision(18, 2);
            builder.Property(z => z.Tax).HasPrecision(18, 2);
            builder.Property(z => z.TaxedValue).HasPrecision(18, 2);
        }
    }

    public class EkthesiEpidoshsModelConfiguration : IEntityTypeConfiguration<EkthesiEpidoshsModel>
    {
        public void Configure(EntityTypeBuilder<EkthesiEpidoshsModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Location).HasMaxLength(200);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(300);
            builder.Property(e => e.Perigrafh).HasMaxLength(5000);
            builder.Property(e => e.Kleisimo).HasMaxLength(2000);
        }
    }

    public class DebtorForSunexisiConfiguration : IEntityTypeConfiguration<DebtorForSunexisi>
    {
        public void Configure(EntityTypeBuilder<DebtorForSunexisi> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(300);
            builder.Property(d => d.Description).HasMaxLength(5000);
        }
    }

    public class BankConfiguration : IEntityTypeConfiguration<PistotikaIdrymataUpoEkkatharisi>
    {
        public void Configure(EntityTypeBuilder<PistotikaIdrymataUpoEkkatharisi> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(300);
            builder.Property(b => b.DiakritikosTitlos).HasMaxLength(300);
            builder.Property(b => b.Edra).HasMaxLength(500);
            builder.Property(b => b.AFM).HasMaxLength(50);
        }
    }
}
