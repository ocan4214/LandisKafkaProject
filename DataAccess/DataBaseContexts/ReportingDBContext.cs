using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataBaseContexts
{
    public class ReportingDBContext : DbContext
    {
        public DbSet<ReportingDataModel> reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EnergyLite.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportingDataModel>().Property(p => p.ReportState).HasConversion<string>();
        }

    }
}
