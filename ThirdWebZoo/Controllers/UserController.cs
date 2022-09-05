using Microsoft.AspNetCore.Mvc;

namespace ThirdWebZoo.Controllers
{
    public class UserController : Controller
    {
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
            return View();/*RedirectToAction("Index")*/
        }
    }
}
