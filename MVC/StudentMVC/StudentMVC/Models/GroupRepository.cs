using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMVC.Models
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext dbContext;

        public GroupRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Group> GetAll()
        {
            return dbContext.Groups.ToList();
        }
    }
}
