using System.Collections.Generic;

namespace Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int ImageThumbnailUrl { get; set; }
        public bool IsProductHot { get; set; }
        public bool InStock { get; set; }

        public int CatelogyId { get; set; }
        public Catelogy Catelogy { get; set; }

        public ShoppingCartItem ShoppingCartItem { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}