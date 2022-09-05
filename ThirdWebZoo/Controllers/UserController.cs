using Microsoft.AspNetCore.Mvc;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _ar;
        public UserController(IUserRepository ar)
        {
            _ar = ar;
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
        public IActionResult SignUp(string firstName, string lastName, int age, string e_mail, string password, string userName)
        {
            _ar.NewUser(firstName, lastName, age, e_mail, password, userName);
            return View();/*RedirectToAction("Index", "Home")*/
        }
    }
}