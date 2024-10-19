using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataBaseContexts
{
    public class CounterDBContext : DbContext
    {
        public DbSet<CounterDataModel> counters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EnergyLite.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed dummy data for CounterDataModel
            modelBuilder.Entity<CounterDataModel>().HasData(
                new CounterDataModel
                {
                    UUID = Guid.NewGuid().ToString(),
                    SerialNo = "SN10001",
                    ReadDate = DateTime.Now.AddDays(-10),
                    LastIndexValue = 123.45m,
                    ReadVoltageValue = 220.5m,
                    ReadAmperValue = 15.2m,
                    ReaderName = "John Doe"
                },
                new CounterDataModel
                {
                    UUID = Guid.NewGuid().ToString(),
                    SerialNo = "SN10002",
                    ReadDate = DateTime.Now.AddDays(-5),
                    LastIndexValue = 150.75m,
                    ReadVoltageValue = 215.3m,
                    ReadAmperValue = 14.8m,
                    ReaderName = "Jane Smith"
                },
                new CounterDataModel
                {
                    UUID = Guid.NewGuid().ToString(),
                    SerialNo = "SN10003",
                    ReadDate = DateTime.Now,
                    LastIndexValue = 175.95m,
                    ReadVoltageValue = 230.1m,
                    ReadAmperValue = 16.0m,
                    ReaderName = null
                }
            );
        }



    }
}
