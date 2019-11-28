using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models.Repository
{
    public interface IOrderRepo
    {
        IEnumerable<Order> GetProduct();
    }

    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext dbContext;
        public OrderRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Order> GetProduct()
        {
            var result = from p in dbContext.Orders
                         .Include(d => d.Product).Include(c => c.Table).ToList()
                         select p;
            return result;
        }
    }
}
