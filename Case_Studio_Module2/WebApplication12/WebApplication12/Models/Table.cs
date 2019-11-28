using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public bool Status { get; set; }
        public string ImgTable { get; set; }

        public List<Order> Orders { get; set; }
    }
}
