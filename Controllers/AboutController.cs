using Microsoft.AspNetCore.Mvc;

namespace SimpleRegistrationProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}