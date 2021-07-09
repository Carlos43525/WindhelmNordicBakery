using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindhelmNordicBakery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageFile { get; set; }
        public string ImageThumbnailFile { get; set; }
        public int Popularity { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
