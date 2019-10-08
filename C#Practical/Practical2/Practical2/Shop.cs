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
        public void AddProduct(Product product)
        {
            //Product product = new Product();
            Console.Write("Nhập tên của sản phẩm: ");
            product.Name = Console.ReadLine();
            Console.Write("Mô tả của sản phẩm: ");
            product.Description = Console.ReadLine();
            //Console.Write("Nhập giá của sản phẩm: ");
            //product.Price = Int32.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập giá của sản phẩm: ");
                product.Price = Int32.Parse(Console.ReadLine());
            } while (0 > product.Price && product.Price < 100);
           
            int[] Rate = new int[10];
            int sum = 0;
            for (int i = 0; i <10; i++)
            {
                Console.Write("Nhập đánh giá của sản phẩm(1-5): ");
                product.Rate[i] = Int32.Parse(Console.ReadLine());
                sum += product.Rate[i];
            }
            listProduct.Add(product);

        }


        public void RemoveProduct(string name)
        {
            int size = listProduct.Count;
            for (int i = 0; i < size; i++)
            {
                if(name == listProduct[i].Name)
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
        public void SearchProduct(double begin_price, double end_price)
        {
            int size = listProduct.Count;
            for (int i = 0; i < size; i++)
            {
                if (begin_price < listProduct[i].Price && listProduct[i].Price < end_price)
                {
                    listProduct[i].ViewInfor();
                }
            }           
        }
    }
}
