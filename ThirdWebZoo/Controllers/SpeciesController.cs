using Microsoft.AspNetCore.Mvc;
using TheZOO.Data;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class SpeciesController : Controller
    {
        private IGeneralRepository _ar;
        public SpeciesController(IGeneralRepository ar)
        {
            _ar = ar;
        }
        public IActionResult IndexSpec(int categoryId)
        {
            var animal = _ar.GetByCategory(categoryId);
            var category = _ar.CategoryName(categoryId);
            ViewBag.Name = category;
            return View(animal);
        }
    }
}
