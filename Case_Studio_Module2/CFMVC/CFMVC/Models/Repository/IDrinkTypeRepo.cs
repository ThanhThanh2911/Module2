using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMVC.Models.Repository
{
    public interface IDrinkTypeRepo
    {
        IEnumerable<DrinkType> GetAll { get; }
    }

    public class DrinkTypeRepo : IDrinkTypeRepo
    {
        private readonly AppDbContext dbContext;

        public DrinkTypeRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        IEnumerable<DrinkType> IDrinkTypeRepo.GetAll => dbContext.DrinkTypes;
    }
}
