using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Vivien.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
