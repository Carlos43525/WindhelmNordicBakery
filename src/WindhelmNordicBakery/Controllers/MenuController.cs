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

        public ViewResult Products()
        {
            MenuProductsViewModel menuProductsViewModel = new MenuProductsViewModel();
            menuProductsViewModel.Products = _productRepository.AllProducts;

            menuProductsViewModel.CurrentCategory = "All Products";
            return View(menuProductsViewModel);
        }
    }
}