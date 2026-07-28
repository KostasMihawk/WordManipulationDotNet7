using Microsoft.EntityFrameworkCore;
using WordManipulationDotNet7.Data.Configurations;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Baillif> Baillifs { get; set; }
        public DbSet<Attorney> Attorneys { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<EkthesiEpidoshsModel> EkthesiEpidoshsModels { get; set; }
        public DbSet<DebtorForSunexisi> DebtorsForSunexisi { get; set; }
        public DbSet<PistotikaIdrymataUpoEkkatharisi> Banks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure table names
            modelBuilder.Entity<Baillif>().ToTable("Baillifs");
            modelBuilder.Entity<Attorney>().ToTable("Attorneys");
            modelBuilder.Entity<Fund>().ToTable("Funds");
            modelBuilder.Entity<Zone>().ToTable("Zones");
            modelBuilder.Entity<EkthesiEpidoshsModel>().ToTable("EkthesiEpidoshsModels");
            modelBuilder.Entity<DebtorForSunexisi>().ToTable("DebtorsForSunexisi");
            modelBuilder.Entity<PistotikaIdrymataUpoEkkatharisi>().ToTable("Banks");

            // Apply configurations
            modelBuilder.ApplyConfiguration(new BaillifConfiguration());
            modelBuilder.ApplyConfiguration(new AttorneyConfiguration());
            modelBuilder.ApplyConfiguration(new FundConfiguration());
            modelBuilder.ApplyConfiguration(new ZoneConfiguration());
            modelBuilder.ApplyConfiguration(new EkthesiEpidoshsModelConfiguration());
            modelBuilder.ApplyConfiguration(new DebtorForSunexisiConfiguration());
            modelBuilder.ApplyConfiguration(new BankConfiguration());
        }
    }
}
