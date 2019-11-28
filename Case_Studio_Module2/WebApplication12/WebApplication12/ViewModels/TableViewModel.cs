using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.Models;

namespace WebApplication12.ViewModels
{
    public class TableViewModel
    {
        public Table Table { get; set; }
        public decimal TableTotal { get; set; }
        public IEnumerable<Table> Tables { get; set; }
    }
}
