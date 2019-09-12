using System;
using System.Text;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Shop product = new Shop();
            int num;
            do
            {
                Menu();
                Console.Write("Nhập số: ");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Write("Nhập số lượng sản phẩm: ");
                        int n = Int32.Parse(Console.ReadLine());
                        //Shop p = new Shop();
                        //Product pr = new Product();
                        //p.AddProduct(pr);
                        for (int i = 0; i < n; i++)
                        {
                            product.AddProduct();
                        }
                        break;
                    case 2:
                        product.RemoveProduct();
                        break;
                    case 3:
                        product.IterateProductList();
                        break;
                    case 4:
                        product.SearchProduct();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Bạn đã nhập sai công việc!");
                        break;
                }
            } while (num != 5);
        }
        public static void Menu()
        {
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("   CHỌN CÔNG VIỆC:");
            Console.WriteLine("1. Add new product.");
            Console.WriteLine("2. Remove product.");
            Console.WriteLine("3. Iterate product list.");
            Console.WriteLine("4. Search product.");
            Console.WriteLine("5. Exit.");
        }
    }
}
