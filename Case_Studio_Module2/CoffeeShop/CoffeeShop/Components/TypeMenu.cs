using CoffeeShop.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Components
{
    public class TypeMenu : ViewComponent
    {
        private readonly IDrinkTypeRepo drinkType;

        public TypeMenu(IDrinkTypeRepo drinkType)
        {
            this.drinkType = drinkType;
        }

        public IViewComponentResult Invoke()
        {
            var type = drinkType.GetAll.OrderBy(t => t.Name);
            return View(type);
        }
    }
}
