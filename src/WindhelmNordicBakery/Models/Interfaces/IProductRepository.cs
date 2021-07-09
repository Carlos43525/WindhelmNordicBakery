using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindhelmNordicBakery.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> PopularProducts { get; }
        Product GetProductById(int productId);
    }
}
