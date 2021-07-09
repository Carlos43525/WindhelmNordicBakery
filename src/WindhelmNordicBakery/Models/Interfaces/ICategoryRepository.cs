using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindhelmNordicBakery.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}