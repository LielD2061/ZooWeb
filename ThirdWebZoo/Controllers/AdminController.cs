using Microsoft.AspNetCore.Mvc;
using ThirdWebZoo.Models;
using ThirdWebZoo.Repositories;

namespace ThirdWebZoo.Controllers
{
    public class AdminController : Controller
    {
        private IGeneralRepository _ar;
        private IAdminRepository _adminRepository;
        public AdminController(IGeneralRepository ar, IAdminRepository adminRepository)
        {
            _ar = ar;
            _adminRepository = adminRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UsingAdmin(Admin admin)
        {
            var adminview = _adminRepository.AllowAdmin(admin);
            ViewBag.AdminName = admin.AdminName;
            if (adminview) return View(adminview);
            return View();
        }
        public IActionResult AddAnimal()
        {
            var stam = _ar.GetData();
            ViewBag.GetId = stam.AllAnimals!.ToList().Count;
            return View();
        }
        [HttpPost]
        public IActionResult AddAnimal1(Animal animal)
        {
            _adminRepository.AddAnimal(animal);
            return RedirectToAction("UsingAdmin");
        }
        public IActionResult AdminSelection()
        {
            var animal = _ar.GetData();
            return View(animal);
        }
        public IActionResult DeleteAnimal1(int animalId)
        {
            _adminRepository.RemoveAnimal(animalId);
            return RedirectToAction("UsingAdmin");
        } 
        public IActionResult GetToComments(int animalId)
        {
            var selectedanimal = _ar.GetAnimal(animalId);
            ViewBag.AnimalName = selectedanimal.Name;
            ViewBag.Animalspecies = selectedanimal.Species;
            ViewBag.AnimalDescription = selectedanimal.Description;
            ViewBag.Animalclass = selectedanimal.AnimalClass;
            ViewBag.Animalage = selectedanimal.AnimalAge;
            ViewBag.Animalcategory = selectedanimal.CategoryId;

            var comments = _adminRepository.GetAllComments(animalId);
            return View(comments);
        }
        public IActionResult DeleteComment(int commentId)
        {
            _adminRepository.DeleteComment(commentId);
            return RedirectToAction("AdminSelection");
        }
        public IActionResult EditComment(int commentId, string editedcomment)
        {
            _adminRepository.EditComment(commentId, editedcomment);
            return RedirectToAction("AdminSelection");
        }
    }
}