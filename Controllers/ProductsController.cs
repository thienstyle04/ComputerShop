﻿using ComputerShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }
        
    }
}
