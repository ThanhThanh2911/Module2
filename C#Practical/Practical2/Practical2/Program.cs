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
                Shop product1 = new Shop();
                Product product2 = new Product();
                switch (num)
                {
                    case 1:
                        Console.Write("Nhập số lượng sản phẩm: ");
                        int n = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            product1.AddProduct(product2);
                        }
                        break;
                    case 2:
                        Console.Write("NHẬP TÊN SẢN PHẨM MUỐN XÓA: ");
                        string name = Console.ReadLine();
                        product1.RemoveProduct(name);
                        break;
                    case 3:
                        product1.IterateProductList();
                        break;
                    case 4:
                        Console.Write("Nhập giá thứ nhất: ");
                        double begin_price = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhập giá thứ hai: ");
                        double end_price = Int32.Parse(Console.ReadLine());
                        product1.SearchProduct(begin_price, end_price);
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
