using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGeneralRepository _generalrepository;
        public static bool AdminLog = false;
        public static bool UserLog = false;
        public HomeController(/*ILogger<HomeController> logger,*/ IGeneralRepository generalrepository)
        {
            //_logger = logger;
            _generalrepository = generalrepository;
        }
        public IActionResult SignAdmin(bool isAdmin)
        {
            AdminLog = isAdmin;
            return RedirectToAction("Index");
        }
        public IActionResult SignUser(bool isUser)
        {
            UserLog = isUser;
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            IEnumerable<Animal> allAnimals = _generalrepository.GetTwoHighestComments();
            ViewBag.Admin = AdminLog;
            ViewBag.User = UserLog;
            string empty = "0";
            ViewBag.Empty = empty;
            return View(allAnimals);
        }
        public IActionResult Map()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Prices()
        {
            ViewBag.Admin = AdminLog;
            ViewBag.User = UserLog;
            return View();
        }
    }
}