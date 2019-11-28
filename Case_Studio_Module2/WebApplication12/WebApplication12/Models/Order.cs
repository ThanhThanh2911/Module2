using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
