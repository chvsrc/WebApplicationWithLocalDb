using AspMvcWebApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspMvcWebApplication.DatabaseContext
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("SqlServerConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
