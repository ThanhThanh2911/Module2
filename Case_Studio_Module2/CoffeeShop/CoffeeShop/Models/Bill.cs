using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Bill
    {
        public int BillId { get; set; }

        public string TableId { get; set; }
        public Table Table { get; set; }

        public DateTime TimePayment { get; set; }
        public int Total { get; set; }
        public bool Status { get; set; }

        public List<BillDetail> BillDetails { get; set; }
    }
}
