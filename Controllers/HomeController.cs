using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
