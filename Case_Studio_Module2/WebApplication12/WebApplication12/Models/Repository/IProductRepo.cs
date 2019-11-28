using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models.Repository
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> Drinks { get; }
        Product GetById(int id);
        IEnumerable<Product> GetByName(string name);
        List<Order> GetOrders(int productId);
        void AddToTable(Product product, int amount, int tableId);
    }

    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _db;

        [BindProperty]
        public Table Table { get; set; }

        public ProductRepo(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> Drinks => _db.Products.Include(t => t.Orders).ToList();

        public IEnumerable<Order> Drink => _db.Orders.Include(t => t.Table).Include(t => t.Product).ToList();

        public List<Order> GetOrders(int productId)
        {
            var Orders = _db.Orders.Where(t => t.Product.ProductId == productId)
                            .Include(d => d.Table)
                            .ToList();

            return Orders;
        }
        public void AddToTable(Product product, int amount, int tableId)
        {
            var order = _db.Orders.Include(t => t.Table).SingleOrDefault(o => o.Product.ProductId == product.ProductId && o.TableId == tableId);

            if (order == null)
            {
                order = new Order();
                order.Product = product;
                order.Amount = amount;
                order.TableId = tableId;
                order.Table = Table;
                _db.Orders.Add(order);
            }
            else
            {
                order.Amount++;
            }

            _db.SaveChanges();

        }

        public IEnumerable<Product> GetAll()
        {
            var result = from p in _db.Products.Include(o => o.Orders).ToList()
                         select p;
            return result;
        }

        public Product GetById(int id)
        {
            return _db.Products.Include(o => o.Orders).FirstOrDefault(p => p.ProductId == id);
        }

        IEnumerable<Product> IProductRepo.GetByName(string name)
        {
            var result = from p in _db.Products
                         where string.IsNullOrEmpty(name) || p.ProductName.Contains(name)
                         select p;
            return result;
        }

        
    }
}
