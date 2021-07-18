using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindhelmNordicBakery.Data;

namespace WindhelmNordicBakery.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext; 
        }
        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }  

        public IEnumerable<Product> PopularProducts => throw new NotImplementedException();

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
