using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindhelmNordicBakery.Models;

namespace WindhelmNordicBakery.ViewModels
{
    public class MenuProductsViewModel
    {
        public int ProductId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}