using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class BillDetail
    {
        public int BillDetailId { get; set; }

        public int BillId { get; set; }
        public Bill Bill { get; set; }

        public int DrinkId { get; set; }
        public Drink Drink { get; set; }

        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
