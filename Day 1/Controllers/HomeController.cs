using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    { 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Employee_Details()
        {
            return View();
        }

        public IActionResult Department_Page()
        {
            return View();
        }

        public IActionResult Contact_Us()
        {
            return View();
        }

        public IActionResult About_Us()
        {
            return View();
        }

    }
}