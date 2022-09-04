using Microsoft.AspNetCore.Mvc;

namespace ThirdWebZoo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
