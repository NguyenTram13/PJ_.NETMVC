using Microsoft.AspNetCore.Mvc;
using ProjectFirst.Models;
using System.Diagnostics;

namespace ProjectFirst.Controllers
{
    public class AdminController : Controller
    {
        

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
