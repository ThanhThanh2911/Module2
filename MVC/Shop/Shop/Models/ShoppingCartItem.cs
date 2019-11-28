using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string Amount { get; set; }
        public int ShoppingCartId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
