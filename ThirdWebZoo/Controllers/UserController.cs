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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User user,DateTime currentDate)
        {
            //user.Age = DateTime.Today.Add(-user.Age);
            _userData.NewUser(user);
            return RedirectToAction("SignUp","User");
        }
        public IActionResult GetSignUpData()
        {
            if (!ModelState.IsValid)
            {
            return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}