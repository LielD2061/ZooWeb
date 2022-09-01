using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheZOO.Data;
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
<<<<<<< HEAD
=======
            //var animal = _ar.GetData();
>>>>>>> 541e69bc44b9e593ad58d1cc2a5a134606d7b6ef
            var animal = _ar.GetTwoHighestComments();
            return View(animal);
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