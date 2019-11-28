using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMVC.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImgDrink { get; set; }

        public int DrinkTypeId { get; set; }
        public DrinkType DrinkType { get; set; }
    }
}
