using Microsoft.AspNetCore.Mvc;
using ComputerShop.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using ComputerShop.Models;

namespace ComputerShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View(productRepository.GetTrendingProducts());
        }
    }
}
