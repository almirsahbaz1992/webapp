using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VeterinarskaStanica.Helper;

namespace Veterinarska_Stanica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Login", "Login", new {area = "ModulLogin"});
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
