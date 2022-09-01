using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheZOO.Data;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class AnimalsController : Controller
    {
        private IAllAnimalRepository _ar;
        public AnimalsController(IAllAnimalRepository ar)
        {
            _ar = ar;
        }
        public IActionResult AllAnimals()
        {
            var animal = _ar.GetData();
            return View(animal);
        }
    }
}
