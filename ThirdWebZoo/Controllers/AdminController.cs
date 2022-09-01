using Microsoft.AspNetCore.Mvc;
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
        public IActionResult UsingAdmin(string username, string password)
        {
            return View();
        }
    }
}
