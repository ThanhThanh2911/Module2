using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManagement.Models
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext dbContext;

        public ContactRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Contact Add(Contact newContact)
        {
            dbContext.Contacts.Add(newContact);
            return newContact;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public Contact Delete(int id)
        {
            var contact = GetById(id);
            if (contact != null)
            {
                dbContext.Contacts.Remove(contact);
            }
            return contact;
        }

        public IEnumerable<Contact> GetAll()
        {
            var contact = from c in dbContext.Contacts.Include(q => q.QueQuan).ToList()
                          select c;
            return contact;
        }

        public Contact GetById(int id)
        {
            return dbContext.Contacts.Include(q => q.QueQuan).SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Contact> GetContactByName(string name)
        {
            var result = from c in dbContext.Contacts.Include(g => g.QueQuan)
                         where string.IsNullOrEmpty(name) || c.Ho.Contains(name) || c.Ten.Contains(name)
                         select c;
            return result;
        }
    }
}
