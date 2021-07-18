using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindhelmNordicBakery.Data;

namespace WindhelmNordicBakery.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}
