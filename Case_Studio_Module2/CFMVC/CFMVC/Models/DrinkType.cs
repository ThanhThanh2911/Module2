using System.Collections.Generic;

namespace CFMVC.Models
{
    public class DrinkType
    {
        public int DrinkTypeId { get; set; }
        public string Name { get; set; }

        public List<Drink> Drinks { get; set; }
    }
}