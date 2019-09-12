using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
    class Shop
    {
        private List<Product> listProduct;
        //private double price;
        //private object product;

        internal List<Product> ListProduct { get => listProduct; set => listProduct = value; }
        //public double Price { get; private set; }

        public Shop()
        {
            listProduct = new List<Product>();
        }
        public void AddProduct()
        {
            Product product = new Product();
            Console.Write("Nhập tên của sản phẩm: ");
            product.Name = Console.ReadLine();
            Console.Write("Mô tả của sản phẩm: ");
            product.Description = Console.ReadLine();
            Console.Write("Nhập giá của sản phẩm: ");
            product.Price = Int32.Parse(Console.ReadLine());
            listProduct.Add(product);

        }


        public void RemoveProduct()
        {
            int size = listProduct.Count;
            Console.Write("NHẬP TÊN SẢN PHẨM MUỐN XÓA: ");
            string del = Console.ReadLine();
            for (int i = 0; i < size; i++)
            {
                if(del == listProduct[i].Name)
                {
                    listProduct.Remove(listProduct[i]);
                }
            }
        }
        public void IterateProductList()
        {
            foreach (var item in listProduct)
            {
                item.ViewInfor();
            }
        }
        public void SearchProduct()
        {
            Console.Write("Nhập giá thứ nhất: ");
            double begin = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập giá thứ hai: ");
            double end = Int32.Parse(Console.ReadLine());
            int size = listProduct.Count;
            for (int i = 0; i < size; i++)
            {
                if (begin < listProduct[i].Price && listProduct[i].Price < end)
                {
                    listProduct[i].ViewInfor();
                }
            }           
        }
    }
}
