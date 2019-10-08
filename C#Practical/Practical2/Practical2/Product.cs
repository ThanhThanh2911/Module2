using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
    class Product
    {
        private string name;
        private string description;
        private double price;
        private int[] rate;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int[] Rate { get => rate; set => rate = value; }

        public Product()
        {

        }
        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        
        public void ViewInfor()
        {
            Console.WriteLine("Tên sản phẩm: {0}", Name);
            Console.WriteLine("Mô tả sản phẩm: {0}", Description);
            Console.WriteLine("Giá của sản phẩm: {0}", Price);
            Console.WriteLine("Đánh giá của sản phẩm: {0}", Rate);
        }
    }
}
