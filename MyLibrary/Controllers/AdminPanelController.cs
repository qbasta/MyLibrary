using Microsoft.AspNetCore.Mvc;

namespace MyLibrary.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoleManager()
        {
            return RedirectToAction("Index", "RoleManager");
        }
        
        public IActionResult UserRoles()
        {
            return RedirectToAction("Index", "UserRoles");
        }
    }
}
