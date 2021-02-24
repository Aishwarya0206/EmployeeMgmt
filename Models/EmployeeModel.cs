using Microsoft.EntityFrameworkCore;
namespace EmployeeMgmt
{
    public class EmployeeMgmtContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2347BSD\SQLEXPRESS;Database=EmployeeDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            
        }
    }
}