using CarMainShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.AccessControl;

namespace CarMainShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Audi()
        {
            return View();
        }
        public IActionResult Mustang()
        {
            return View();
        }
    }
    
}
