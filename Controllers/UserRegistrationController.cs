using Microsoft.AspNetCore.Mvc;
using SimpleRegistrationProject.Models;

namespace SimpleRegistrationProject.Controllers
{
    public class UserRegistrationController : Controller
    {
        [HttpGet]
        public IActionResult RegistrationPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(UserRegistrationModel user)
        {
            if (user != null && user.IsAgree)
            {
                return View("Accept", user);
            }
            else
            {
                return NotFound();
            }
        }
    }
}