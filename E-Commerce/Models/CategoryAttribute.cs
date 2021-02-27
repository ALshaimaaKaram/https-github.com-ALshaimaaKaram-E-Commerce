using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class CategoryAttribute
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public AttributeLookUp AttributeLookUp { get; set; }
    }
}
