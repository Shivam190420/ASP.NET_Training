using WebApplication1.Models;

namespace WebApplication1.Repositries
{
    public class Employee_repo : IEmployee_repo
    {
            EmployeeDbContext _context;

            public Employee_repo(EmployeeDbContext context)
            {
                _context = context;
            }

            public void AddEmployee(Employee obj)
            {
                _context.Employees.Add(obj);
                _context.SaveChanges();
            }

            public void DeleteEmployee(int id)
            {
            Employee obj = _context.Employees.Find(id);
                _context.Employees.Remove(obj);
                _context.SaveChanges();
            }

            public List<Employee> GetAllEmployee()
            {
                List<Employee> stList = _context.Employees.ToList();
                return stList;
            }

            public Employee GetEmployeeById(int id)
            {
            Employee obj = _context.Employees.Find(id);
                return obj;
            }

            public void UpdateEmployee(Employee obj)
            {
                _context.Employees.Update(obj);
                _context.SaveChanges();
            }

            public IEnumerable<Employee> GetEmployeebyjob(string jobName)
            {
            IEnumerable<Employee> lst = _context.Employees.Where(i => i.Job == jobName);
                return lst;
            }

        public IEnumerable<Employee> GetEmployeebydeptno(int no)
        {
            IEnumerable<Employee> lst = _context.Employees.Where(i => i.Deptno == no);
            return lst;
        }
    }
}
