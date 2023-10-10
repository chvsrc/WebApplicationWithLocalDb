using AspMvcWebApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspMvcWebApplication.DatabaseContext
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}
