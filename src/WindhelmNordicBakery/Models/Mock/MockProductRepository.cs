using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindhelmNordicBakery.Models.Mock
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {Id=1, Name="Sourdough", Price=4.99M, ShortDescription="Lorem Ipsum", LongDescription=" Curabitur ullamcorper nulla non enim hendrerit aliquam. Aenean luctus viverra ante a placerat. Nam mollis consectetur varius. Sed eleifend facilisis viverra. Mauris in urna eget mi ullamcorper elementum. Mauris ultrices ante mauris, at congue dui pulvinar faucibus. Nunc eget est a sem blandit placerat quis quis nisl. Nullam condimentum quis eros blandit rutrum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec et libero nec enim sodales fermentum at a libero.", Category=_categoryRepository.AllCategories.ToList()[0], ImageFile="sourdough.jpg", ImageThumbnailFile="sourdough.jpg", Popularity=4, InStock=true}, 
                new Product {Id=1, Name="Viking Rye Bread", Price=2.99M, ShortDescription="Lorem Ipsum", LongDescription=" Curabitur ullamcorper nulla non enim hendrerit aliquam. Aenean luctus viverra ante a placerat. Nam mollis consectetur varius. Sed eleifend facilisis viverra. Mauris in urna eget mi ullamcorper elementum. Mauris ultrices ante mauris, at congue dui pulvinar faucibus. Nunc eget est a sem blandit placerat quis quis nisl. Nullam condimentum quis eros blandit rutrum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec et libero nec enim sodales fermentum at a libero.", Category=_categoryRepository.AllCategories.ToList()[1], ImageFile="VikingRye.jpg", ImageThumbnailFile="VikingRye.jpg", Popularity=1, InStock=true}
            };

        public IEnumerable<Product> PopularProducts { get; }
        
        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.Id == productId); 
        }
    }
}
