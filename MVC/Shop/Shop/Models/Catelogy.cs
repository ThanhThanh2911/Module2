using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Catelogy
    {
        public int CatelogyId { get; set; }
        public string CatelogyName { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
