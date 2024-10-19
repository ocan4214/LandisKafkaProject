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

            modelBuilder.Entity<ReportingDataModel>().HasData(
            new ReportingDataModel
            {
                UUID = Guid.NewGuid().ToString(),
                RequestedDate = DateTime.Now.AddDays(-2),
                ReportState = ReportStatusEnum.Pending,
                ReportDescription = "Sample report description 1"
            },
            new ReportingDataModel
            {
                UUID = Guid.NewGuid().ToString(),
                RequestedDate = DateTime.Now.AddDays(-1),
                ReportState = ReportStatusEnum.Processing,
                ReportDescription = "Sample report description 2"
            },
            new ReportingDataModel
            {
                UUID = Guid.NewGuid().ToString(),
                RequestedDate = DateTime.Now,
                ReportState = ReportStatusEnum.Shipped,
                ReportDescription = "Sample report description 3"
            }
             );






        }

    }
}
