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
        public IActionResult SignIn(Admin admin)
        {
            bool adminview = _adminRepository.AllowAdmin(admin);
            ViewBag.AdminName = admin.AdminName;
            return adminview ? RedirectToAction("UsingAdmin") : RedirectToAction("Index");
        }
        public IActionResult UsingAdmin()
        {
            ViewBag.Admin = HomeController.AdminLog = true;
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
            _adminRepository.CheckAddAnimal(animal);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult AdminSelection()
        {
            var animal = _ar.GetData();
            return View(animal);
        }
        public IActionResult DeleteAnimal(int animalId)
        {
            _adminRepository.CheckRemoveAnimal(animalId);
            return RedirectToAction("AllAnimals", "Animals");
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
            _adminRepository.CheckDeleteComment(commentId);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult EditComment(int commentId, string editedcomment)
        {
            _adminRepository.EditComment(commentId, editedcomment);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult EditAnimal(int animalId)
        {
            var getanimal = _ar.GetAnimal(animalId);
            return View(getanimal);
        }
        public IActionResult EditAnimal1(Animal animal)
        {
            _adminRepository.EditAnimal(animal);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult GetCreateAdmin()
        {
            return View();
        }
        public IActionResult CreateAdmin(Admin admin)
        {
            _adminRepository.CreateAdmin(admin);
            return View();
        }
        public IActionResult LogOut()
        {
            return RedirectToAction("SignAdmin", "Home", new { isAdmin = false });
        }
    }
}