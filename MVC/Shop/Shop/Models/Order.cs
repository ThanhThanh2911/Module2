using System.Collections.Generic;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrderTotal { get; set; }
        public string OrderPlaced { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}