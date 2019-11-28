using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Repository
{
    public interface IDrinkRepo
    {
        IEnumerable<Drink> GetAll();
        Drink GetById(int id);
        Drink Add(Drink drink);
        Drink Update(Drink drink);
        Drink Delete(Drink drink);
        IEnumerable<Drink> GetByDrink(string name);
        IEnumerable<Drink> PreferredDrink { get; }
        int Commit();     
    }
}
