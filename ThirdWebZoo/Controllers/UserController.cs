﻿using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
        public IActionResult SignIn(string Password, string UserName)
        {
            if(_userData.IsExist(Password, UserName))
                return RedirectToAction("Index", "Home");
            return RedirectToAction("Index");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User user)
        {
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