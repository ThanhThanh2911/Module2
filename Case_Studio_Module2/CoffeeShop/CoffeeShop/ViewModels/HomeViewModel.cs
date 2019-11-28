using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
    }
}
