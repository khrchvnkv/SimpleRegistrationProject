using Microsoft.AspNetCore.Mvc;

namespace SimpleRegistrationProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}