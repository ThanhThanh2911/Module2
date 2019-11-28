using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMVC.Models
{
    public class Table
    {
        private readonly AppDbContext db;

        public Table(AppDbContext db)
        {
            this.db = db;
        }

        public string TableId { get; set; }
        public string TableName { get; set; }
        public bool Status { get; set; }

        public Bill Bill { get; set; }

        public List<Order> Orders { get; set; }
        public AppDbContext Db { get; }

        public static Table GetTable(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string tableId = session.GetString("ItemId") ?? Guid.NewGuid().ToString();

            session.SetString("ItemId", tableId);

            return new Table(context) { TableId = tableId };


        }


        public void AddToTable(Drink drink, int amount)
        {
            var order = db.Orders.SingleOrDefault(o => o.Drink.DrinkTypeId == drink.DrinkTypeId && o.TableId == TableId);

            if (order == null)
            {
                order = new Order
                {
                    TableId = TableId,
                    Drink = drink,
                    Amount = 1
                };

                db.Orders.Add(order);
            }
            else
            {
                order.Amount++;
            }
            db.SaveChanges();
        }

        public int RemoveFromTable(Drink drink)
        {
            var order = db.Orders.SingleOrDefault(o => o.Drink.DrinkTypeId == drink.DrinkTypeId && o.TableId == TableId);

            var localAmount = 0;
            if (order != null)
            {
                db.Orders.Remove(order);
            }

            db.SaveChanges();

            return localAmount;
        }

        public int EditMulDrink(Drink drink)
        {
            var order = db.Orders.SingleOrDefault(o => o.Drink.DrinkTypeId == drink.DrinkTypeId && o.TableId == TableId);

            var localAmount = 0;
            if (order != null)
            {
                if (order.Amount > 1)
                {
                    order.Amount--;
                    localAmount = order.Amount;
                }
                else
                {
                    db.Orders.Remove(order);
                }
            }

            db.SaveChanges();

            return localAmount;
        }

        public int EditAddDrink(Drink drink)
        {
            var order = db.Orders.SingleOrDefault(o => o.Drink.DrinkTypeId == drink.DrinkTypeId && o.TableId == TableId);

            var localAmount = 0;
            if (order != null)
            {
                order.Amount++;
                localAmount = order.Amount;
            }

            db.SaveChanges();

            return localAmount;
        }

        public List<Order> GetOrders()
        {
            return Orders ??
                    (Orders = db.Orders.Where(t => t.TableId == TableId)
                            .Include(d => d.Drink)
                            .ToList());
        }

        public void ClearTable()
        {
            var tableItem = db.Orders.Where(t => t.TableId == TableId);

            db.Orders.RemoveRange(tableItem);

            db.SaveChanges();
        }

        public decimal GetTableTotal()
        {
            var total = db.Orders.Where(t => t.TableId == TableId)
                .Select(d => d.Drink.Price * d.Amount).Sum();
            return total;
        }
    }
}
