using Microsoft.AspNetCore.Mvc;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userData;
        public UserController(IUserRepository ud)
        {
            _userData = ud;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(string Password, string UserName)
        {
            if (ModelState.IsValid)
            {
                if (_userData.IsExist(Password, UserName))
                    return RedirectToAction("SignUser", "Home", new { isUser = true});
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User user)
        {
            var newuser = _userData.NewUser(user);
            return newuser? RedirectToAction("SignUser", "Home", new { IsUser = true }) : RedirectToAction("SingUp");
        }
        public IActionResult GetSignUpData()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult LogOut()
        {
            return RedirectToAction("SignUser", "Home", new { isUser = false });
        }
    }
}