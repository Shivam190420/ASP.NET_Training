using WebApplication1.Models;

namespace WebApplication1.Repositries
{
    public interface IEmployee_repo
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetEmployeebyjob(string jobName);
        IEnumerable<Employee> GetEmployeebydeptno(int no);
        void AddEmployee(Employee obj);
        void UpdateEmployee(Employee obj);
        void DeleteEmployee(int id);
    }
}
