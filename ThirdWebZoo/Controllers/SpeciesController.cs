using Microsoft.AspNetCore.Mvc;
using TheZOO.Data;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class SpeciesController : Controller
    {
        private IAllAnimalRepository _ar;
        public SpeciesController(IAllAnimalRepository ar)
        {
            _ar = ar;
        }
        public IActionResult IndexSpec(int categoryId)
        {
            var animal = _ar.GetByCategory(categoryId);
            return View(animal);
        }
    }
}
