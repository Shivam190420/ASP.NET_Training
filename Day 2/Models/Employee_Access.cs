namespace WebApplication2.Models
{
    public class Employee_Access
    {
        public static List<Employee> emp = new List<Employee>();
        public Employee_Access()
        {
            emp = new List<Employee>() {
                new Employee(){ Emp_Id = 10, Emp_Name = "Shivam", Salary = 2400, Job = "SDE" },
                new Employee(){ Emp_Id = 20, Emp_Name = "Adarsh", Salary = 5000, Job = "Product Engineer" },
                new Employee(){ Emp_Id = 30, Emp_Name = "Rohit", Salary = 3000, Job = "Data Analyst" },
            };
        }
        public List<Employee> GetAllDets()
        {
            return emp;
        }
        public Employee GetEmployeeById(int id)
        {
            return emp.Find(item => item.Emp_Id == id);
        }
        public void AddEmployee(Employee obj)
        {
            emp.Add(obj);
        }
        public void DeleteEmployee(int id)
        {
            Employee obj = emp.Find(item => item.Emp_Id == id);
            emp.Remove(obj);
        }
        public void UpdateEmployee(Employee updateObj)
        {
            Employee obj = emp.Find(item => item.Emp_Id == updateObj.Emp_Id);
            emp.Remove(obj);
            emp.Add(updateObj);
        }
    }
}
