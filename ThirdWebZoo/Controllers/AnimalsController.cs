using Microsoft.AspNetCore.Mvc;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class AnimalsController : Controller
    {
        private IGeneralRepository _ar;
        public AnimalsController(IGeneralRepository ar)
        {
            _ar = ar;
        }
        public IActionResult AllAnimals()
        {
            var animal = _ar.GetData();
            return View(animal);
        }
        public IActionResult NewComment(string newComment, int AnimalId)
        {
            return View();
        }
    }
}
