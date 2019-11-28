using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Repository
{
    public interface IOrderRepo
    {
        void CreateOrder(Bill bill);
    }

    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext db;
        private readonly Table table;

        public OrderRepo(AppDbContext db, Table table)
        {
            this.db = db;
            this.table = table;
        }
        public void CreateOrder(Bill bill)
        {
            bill.TimePayment = DateTime.Now;
            db.Bills.Add(bill);

            var orders = table.Orders;

            foreach (var item in orders)
            {
                var billDetail = new BillDetail()
                {
                    Amount = item.Amount,
                    DrinkId = item.Drink.Id,
                    BillId = bill.BillId,
                    Price = item.Drink.Price
                };

                db.BillDetails.Add(billDetail);
            }

            db.SaveChanges();
        }
    }
}
