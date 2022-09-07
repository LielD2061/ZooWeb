using Microsoft.AspNetCore.Mvc;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userData;
        private IGeneralRepository _generalRepository;
        public UserController(IUserRepository ud, IGeneralRepository generalRepository)
        {
            _userData = ud;
            _generalRepository = generalRepository;
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
        public IActionResult GetBorrow(int animalId)
        {
            ViewBag.Admin = HomeController.AdminLog;
            ViewBag.User = HomeController.UserLog;
            _generalRepository.GetAnimal(animalId);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult LogOut()
        {
            return RedirectToAction("SignUser", "Home", new { isUser = false });
        }
    }
}