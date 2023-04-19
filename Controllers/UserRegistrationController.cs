using Microsoft.AspNetCore.Mvc;
using SimpleRegistrationProject.Context;
using SimpleRegistrationProject.Crypt;
using SimpleRegistrationProject.Models;

namespace SimpleRegistrationProject.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly CryptPassword _cryptPassword;

        public UserRegistrationController(CryptPassword cryptPassword)
        {
            _cryptPassword = cryptPassword;
        }
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
                        user.Password = _cryptPassword.Encode(user.Password);
                        user.ConfirmPassword = _cryptPassword.Encode(user.ConfirmPassword);
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
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginModel loginUser)
        {
            if (ModelState.IsValid)
            {
                using (DbUser db = new DbUser())
                {
                    var cryptPassword = _cryptPassword.Encode(loginUser.Password);
                    var dbUser = db.UserInfo.FirstOrDefault(u => 
                        u.Mail == loginUser.Mail && 
                        u.Password == cryptPassword);
                    if (dbUser != null)
                    {
                        return View("AcceptLogin", dbUser);
                    }
                }
            }
            return View();
        }
    }
}