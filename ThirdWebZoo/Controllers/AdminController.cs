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
            return adminview ? RedirectToAction("SignAdmin", "Home", new { isAdmin = true }) : RedirectToAction("Index");
        }
        public IActionResult AddAnimal()
        {
            var stam = _ar.GetData();
            ViewBag.GetId = stam.AllAnimals!.ToList().Count;
            ViewBag.Category1 = _ar.CategoryName(1);
            ViewBag.Category2 = _ar.CategoryName(2);
            ViewBag.Category3 = _ar.CategoryName(3);
            ViewBag.Category4 = _ar.CategoryName(4);
            ViewBag.Category5 = _ar.CategoryName(5);
            return View();
        }
        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _adminRepository.CheckAddAnimal(animal);
                return RedirectToAction("AllAnimals", "Animals");
            }
            return RedirectToAction("AddAnimal");
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
            var stam = _ar.GetData();
            ViewBag.GetId = stam.AllAnimals!.ToList().Count;
            ViewBag.Category1 = _ar.CategoryName(1);
            ViewBag.Category2 = _ar.CategoryName(2);
            ViewBag.Category3 = _ar.CategoryName(3);
            ViewBag.Category4 = _ar.CategoryName(4);
            ViewBag.Category5 = _ar.CategoryName(5);
            return View(getanimal);
        }
        public IActionResult EditAnimal1(Animal animal)
        {
            _adminRepository.EditAnimal(animal);
            return RedirectToAction("AllAnimals", "Animals");
        }
        public IActionResult GetCreateAdmin()
        {
            ViewBag.Admin = HomeController.AdminLog;
            return View();
        }
        public IActionResult CreateAdmin(Admin admin)
        {
            _adminRepository.CreateAdmin(admin);
            return RedirectToAction("SignAdmin", "Home", new { isAdmin = true });
        }
        public IActionResult GetDeleteAdmin()
        {
            ViewBag.Admin = HomeController.AdminLog;
            return View(_adminRepository.GetAllAdmin());
        }
        public IActionResult DeleteAdmin(int adminId)
        {
            _adminRepository.DeleteAdmin(adminId);
            return RedirectToAction("SignAdmin", "Home", new { isAdmin = true });
        }
        public IActionResult GetDeleteUser()
        {
            ViewBag.Admin = HomeController.AdminLog;
            return View(_adminRepository.GetAllUsers());
        }
        public IActionResult DeleteUser(int userId)
        {
            _adminRepository.DeleteUser(userId);
            return RedirectToAction("SignAdmin", "Home", new { isAdmin = true });
        }
        public IActionResult LogOut()
        {
            return RedirectToAction("SignAdmin", "Home", new { isAdmin = false });
        }
    }
}