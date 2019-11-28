using System.Collections.Generic;

namespace ContactManagement.Models
{
    public class QueQuan
    {
        public int QueQuanId { get; set; }
        public string Name { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}