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

        public ViewResult ProductList(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.Id);
                currentCategory = "All pies";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.Id);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new MenuProductsViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
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