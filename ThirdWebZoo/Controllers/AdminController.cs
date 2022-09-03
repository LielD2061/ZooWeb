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
            return adminview ? View() : RedirectToAction("Index","Home");
        }
    }
}