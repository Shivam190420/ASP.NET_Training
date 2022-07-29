using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        EmployeeDbContext _context;
        public ValuesController(EmployeeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var stdList = await _context.Employees.ToListAsync();
            return Ok(stdList);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var stdObj = await _context.Employees.FindAsync(id);

            if (stdObj != null)
                return Ok(stdObj);
            else
                return NotFound("Requested Product Id does not exists.");
        }


        [HttpPost]
        public async Task<IActionResult> AddStudent(Employee obj)
        {
            await _context.Employees.AddAsync(obj);
            await _context.SaveChangesAsync();
            return Ok("New Student details are saved in database.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(Employee obj)
        {
            _context.Employees.Update(obj);
            await _context.SaveChangesAsync();
            return Ok("Student details are updated in database.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var empObj = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(empObj);
            await _context.SaveChangesAsync();
            return Ok("Student details are deleted from database.");
        }
    }
}
