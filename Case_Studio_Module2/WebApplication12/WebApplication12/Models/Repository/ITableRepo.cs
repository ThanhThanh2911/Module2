using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models.Repository
{
    public interface ITableRepo
    {
        IEnumerable<Table> GetTables();
        IEnumerable<Table> Tables { get; }
        Table GetByTable(int id);
        Table Add(Table order);
        void AddToOrders(Product product, int amount, int tableId);
        void AddToTable(Table tableId, int productId);
        int RemoveFromTable(Product product);
        int EditAddProduct(Product product);
        int EditMulProduct(Product product);
        List<Order> GetOrders(int tableId);
        void ClearTable();
        decimal GetTableTotal(int tableId);
    }

    public class TableRepo : ITableRepo
    {
        private readonly AppDbContext _db;

        [BindProperty]
        public Table Table { get; set; }
        public TableRepo(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Table> Tables => _db.Tables.ToList();

        public void AddToOrders(Product product, int amount, int tableId)
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

        public void AddToTable(Table tableId, int productId)
        {
            //var order = AddToOrders(productId);

            //if (order == null)
            //{
            //    order = new Order
            //    {
            //        Amount = 1
            //    };

            //    _db.Orders.Add(order);
            //}
            //else
            //{
            //    order.Amount++;
            //}
            //_db.SaveChanges();
        }

        public void ClearTable()
        {
            throw new System.NotImplementedException();
        }

        public int EditAddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public int EditMulProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Table GetByTable(int id)
        {
            return _db.Tables.SingleOrDefault(t => t.TableId == id);
        }

        public List<Order> GetOrders(int tableId)
        {
            var Orders = _db.Orders.Where(t => t.TableId == tableId)
                            .Include(d => d.Product)
                            .ToList();
            return Orders;
        }

        public IEnumerable<Table> GetTables()
        {
            var table = from t in _db.Tables.ToList()
                        select t;
            return table;
        }

        public decimal GetTableTotal(int tableId)
        {
            var total = _db.Orders.Where(t => t.TableId == tableId)
                .Select(d => d.Product.Price * d.Amount).Sum();
            return total;
        }

        public int RemoveFromTable(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Table Add(Table order)
        {
            _db.Tables.Add(order);
            return order;
        }
    }
}
