using Microsoft.AspNetCore.Mvc;
using SimpleRegistrationProject.Context;
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
            if (ModelState.IsValid)
            {
                if (user != null && user.IsAgree)
                {
                    using (DbUser db = new DbUser())
                    {
                        db.UserInfo.Add(user);
                        db.SaveChanges();
                    }
                    return View("Accept", user);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return View(user);
            }
        }
    }
}