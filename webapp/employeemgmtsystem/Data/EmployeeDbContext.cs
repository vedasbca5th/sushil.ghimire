using employeemgmtsystem.Models;
using Microsoft.EntityFrameworkCore;

public class EmployeeDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Employee.db");
    }
}