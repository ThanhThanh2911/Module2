using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMCV.Models.Repository
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        Product Delete(Product product);
        IEnumerable<Product> GetByDrink(string name);
        IEnumerable<Product> Products { get; }
        int Commit();
    }

    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext db;

        public ProductRepo(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> Products => db.Products.Include(c => c.ProductType);

        public Product Add(Product drink)
        {
            db.Products.Add(drink);
            return drink;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Product Delete(Product drink)
        {
            db.Products.Remove(drink);
            return drink;
        }

        public IEnumerable<Product> GetAll()
        {
            var result = from d in db.Products.Include(t => t.ProductType).ToList()
                         select d;
            return result;
        }

        public IEnumerable<Product> GetByDrink(string name)
        {
            var result = from d in db.Products.Include(t => t.ProductType)
                         where string.IsNullOrEmpty(name) || d.ProductName.Contains(name)
                         select d;
            return result;
        }

        public Product GetById(int id)
        {
            var drink = db.Products.Include(t => t.ProductType).FirstOrDefault(d => d.ProductId == id);
            return drink;
        }

        public Product Update(Product drink)
        {
            var entity = db.Products.Attach(drink);
            entity.State = EntityState.Modified;
            return drink;
        }
    }
}
