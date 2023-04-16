using Microsoft.AspNetCore.Mvc;

namespace SimpleRegistrationProject.Controllers
{
    public class ContactsController : Controller
    {
        // GET
        public IActionResult Contacts()
        {
            return View();
        }
    }
}