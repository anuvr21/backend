using InsuranceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Data
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> option) : base(option)
        {

        }

        public DbSet<model1> Member { get; set; }
        public DbSet<model2> Provider { get; set; }

        public DbSet<model3> Pharmacy { get; set; }
    }
}