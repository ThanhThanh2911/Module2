using CFMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMVC.ViewModels
{
    public class TableViewModel
    {
        public Table Table { get; set; }
        public decimal TableTotal { get; set; }
    }
}
