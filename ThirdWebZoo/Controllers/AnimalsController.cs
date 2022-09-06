using Microsoft.AspNetCore.Mvc;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class AnimalsController : Controller
    {
        private IGeneralRepository _generalRepository;
        private IAdminRepository _adminRepository;
        public AnimalsController(IGeneralRepository ar, IAdminRepository arAdmin)
        {
            _generalRepository = ar;
            _adminRepository = arAdmin;
        }
        public IActionResult AllAnimals()
        {
            ViewBag.Admin = HomeController.AdminLog;
            ViewBag.User = HomeController.UserLog;
            var animal = _generalRepository.GetData();
            string empty = "0";
            ViewBag.Empty = empty;
            return View(animal);
        }
        [HttpPost]
        public IActionResult NewComment(string newComment, int AnimalId)
        {
            _generalRepository.GetNewComment(newComment, AnimalId);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult GetAnimal(int animalId)
        {
            ViewBag.Admin = HomeController.AdminLog;
            ViewBag.User = HomeController.UserLog;
            var selectedanimal = _generalRepository.GetAnimal(animalId);
            ViewBag.AnimalName = selectedanimal.Name;
            ViewBag.Animalspecies = selectedanimal.Species;
            ViewBag.AnimalDescription = selectedanimal.Description;
            ViewBag.Animalclass = selectedanimal.AnimalClass;
            ViewBag.Animalage = selectedanimal.AnimalAge;
            ViewBag.AnimalId = selectedanimal.AnimalId;

            var comments = _adminRepository.GetAllComments(animalId);
            return View(comments);
        }
        public IActionResult IndexSpec(int categoryId)
        {
            ViewBag.Admin = HomeController.AdminLog;
            ViewBag.User = HomeController.UserLog;
            var animal = _generalRepository.GetByCategory(categoryId);
            var category = _generalRepository.CategoryName(categoryId);
            ViewBag.Name = category;
            string empty = "0";
            ViewBag.Empty = empty;
            return View(animal);
        }
    }
}
