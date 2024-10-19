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

    }
}
