using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindhelmNordicBakery.Models.Mock
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category>
            {  
                new Category {CategoryId=1, CategoryName="Bread", Description="Freshly baked Nordic bread."},
                new Category {CategoryId=1, CategoryName="Cakes", Description="Our legendary cakes."},
                new Category {CategoryId=1, CategoryName="Squares", Description="Treat yourself with crumbling goodness."}
            };
    }
}
