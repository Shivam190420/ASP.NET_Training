using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Required]
        public int Emp_Id { get; set; }

        [Required]
        public string Emp_Name { get; set; }
        public int Salary { get; set; }
        public string Job { get; set; }
    }
}
