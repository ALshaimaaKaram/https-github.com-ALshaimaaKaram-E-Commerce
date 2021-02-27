using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Images> Images { get; set; }
        public Category Category { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
