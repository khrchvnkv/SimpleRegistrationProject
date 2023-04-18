using Microsoft.AspNetCore.Mvc;
using SimpleRegistrationProject.Context;

namespace SimpleRegistrationProject.Controllers
{
    public class ContactsController : Controller
    {
        // GET
        public IActionResult Contacts()
        {
            using (DbUser db = new DbUser())
            {
                var users = db.UserInfo.ToList();
                return View(users);
            }
        }
    }
}