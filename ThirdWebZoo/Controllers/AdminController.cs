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
        public IActionResult AddAnimal1(Animal animal)
        {
            _adminRepository.AddAnimal(animal);
            return RedirectToAction("UsingAdmin");
        }
    }
}