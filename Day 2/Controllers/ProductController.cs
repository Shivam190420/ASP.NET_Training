using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;
using System.Linq;


namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        Employee_Access context = new Employee_Access();
        public IActionResult Index()
        {
            List<Employee> products = context.GetAllDets();
            return View(products);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid == true)
            {
                context.AddEmployee(obj);
                return RedirectToAction("Index");

            }
            else
            {

                ViewBag.RequestType = Request.Method;
                ViewBag.ErrorMessage = "Invalid Employee data";
                return View();
            }
        }

        public IActionResult Details(int id)
        {
            Employee obj = context.GetEmployeeById(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = context.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid == true)
            {
                context.UpdateEmployee(obj);
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.RequestType = Request.Method;
                ViewBag.ErrorMessage = "Invalid Employee data";
                return View();
            }
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = context.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            context.DeleteEmployee(id);
            return RedirectToAction("Index");

            // List<Product> products = context.GetAllDets();
            // return View("Index", products);
        }
    }
}
