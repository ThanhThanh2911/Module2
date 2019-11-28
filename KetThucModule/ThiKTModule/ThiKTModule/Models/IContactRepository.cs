using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManagement.Models
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        IEnumerable<Contact> GetContactByName(string name);
        Contact Add(Contact newContact);
        Contact GetById(int id);
        Contact Delete(int id);
        int Commit();
    }
}
