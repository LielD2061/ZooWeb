using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGeneralRepository _ar;

        public HomeController(ILogger<HomeController> logger, IGeneralRepository ar)
        {
            _logger = logger;
            _ar = ar;
        }
        public IActionResult Index()
        {
            AllModel allModel = new AllModel();
            allModel.AllAnimals = _ar.GetTwoHighestComments();
            string empty = "";
            ViewBag.Empty = empty;
            return View(allModel);
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
    }
}