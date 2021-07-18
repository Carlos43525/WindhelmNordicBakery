using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WindhelmNordicBakery.Models;
using WindhelmNordicBakery.ViewModels;

namespace WindhelmNordicBakery.Controllers
{   
    public class MenuController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MenuController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult ProductList()
        {
            MenuProductsViewModel menuProductsViewModel = new MenuProductsViewModel();
            menuProductsViewModel.Products = _productRepository.AllProducts;

            menuProductsViewModel.CurrentCategory = "All Products";
            return View(menuProductsViewModel);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}