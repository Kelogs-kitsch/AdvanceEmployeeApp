using Microsoft.EntityFrameworkCore;

namespace AdvanceEmployeeApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<AdvanceEmployeeApp.Models.Employee> Employees { get; set; }
    }
}