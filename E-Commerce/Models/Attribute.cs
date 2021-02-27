using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AttributeLookUpId { get; set; }
        public string Value { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public Category Category { get; set; }
        public AttributeLookUp AttributeLookUp { get; set; }
        public Product Product { get; set; }
    }
}
