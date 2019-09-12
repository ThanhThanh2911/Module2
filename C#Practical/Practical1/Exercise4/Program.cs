using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;            
            Console.Write("Nhap so thu nhat: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int num2 = Int32.Parse(Console.ReadLine());
            do
            {
                Menu();
                num = Int32.Parse(Console.ReadLine());
                switch(num){
                    case 1:
                        int sum;
                        sum = num1 + num2;
                        Console.WriteLine("Tong la: {0}", sum);
                        break;
                    case 2:
                        int hieu;
                        hieu = num1 - num2;
                        Console.WriteLine("Hieu la: {0}", hieu);
                        break;
                    case 3:
                        double multifly;
                        multifly = num1 * num2;
                        Console.WriteLine("Tich la: {0}", multifly);
                        break;
                    case 4:
                        double diving;
                        diving = num1 / num2;
                        Console.WriteLine("Thuong la: {0}", diving);
                        break;
                    case 5:
                        Console.WriteLine("Ban da thoat khoi chuong trinh!");
                        break;
                }
            } while (num != 5);
            
        }
        private static void Menu()
        {
            Console.WriteLine("Chon cong viec: ");
            Console.WriteLine("1=> Tinh tong");
            Console.WriteLine("2=> Tinh hieu");
            Console.WriteLine("3=> Tinh tich");
            Console.WriteLine("4=> Tinh thuong");
            Console.WriteLine("Thoat khoi chuong trinh!");
        }
    }
}
