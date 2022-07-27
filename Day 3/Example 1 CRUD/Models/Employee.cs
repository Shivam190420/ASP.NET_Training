using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string Emp_name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public int Deptno { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> emp { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
         : base(options)
        {

        }
    }
}
