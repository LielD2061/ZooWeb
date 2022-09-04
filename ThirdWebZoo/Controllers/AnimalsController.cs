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
        [HttpPost]
        public IActionResult NewComment(string newComment, int AnimalId)
        {
            _ar.GetNewComment(newComment, AnimalId);
            return View();
        }
        public IActionResult GetAnimal(int animalId)
        {
            var pickedanimal = _ar.GetAnimal(animalId);
            ViewBag.AnimalName = pickedanimal.Name;
            return View(pickedanimal);
        }
    }
}
