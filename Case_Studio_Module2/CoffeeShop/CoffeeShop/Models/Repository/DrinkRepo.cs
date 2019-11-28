using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShop.Models.Repository
{
    public class DrinkRepo : IDrinkRepo
    {
        private readonly AppDbContext db;

        public DrinkRepo(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Drink> PreferredDrink 
        {
            get
            {
                return db.Drinks.Include(t => t.DrinkType);
            }
        }

        public Drink Add(Drink drink)
        {
            db.Drinks.Add(drink);
            return drink;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Drink Delete(Drink drink)
        {
            db.Drinks.Remove(drink);
            return drink;
        }

        public IEnumerable<Drink> GetAll()
        {
            var result = from d in db.Drinks.Include(t => t.DrinkType).ToList()
                         select d;
            return result;
        }

        public IEnumerable<Drink> GetByDrink(string name)
        {
            var result = from d in db.Drinks.Include(t => t.DrinkType)
                         where string.IsNullOrEmpty(name) || d.Name.Contains(name)
                         select d;
            return result;
        }

        public Drink GetById(int id)
        {
            var drink = db.Drinks.Include(t => t.DrinkType).FirstOrDefault(d => d.Id == id);
            return drink;
        }

        public Drink Update(Drink drink)
        {
            var entity = db.Drinks.Attach(drink);
            entity.State = EntityState.Modified;
            return drink;
        }
    }
}
