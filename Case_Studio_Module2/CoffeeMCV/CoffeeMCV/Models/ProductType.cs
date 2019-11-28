using System.Collections.Generic;

namespace CoffeeMCV.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string TypeName { get; set; }

        public List<Product> Products { get; set; }
    }
}