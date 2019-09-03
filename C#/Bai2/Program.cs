using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int num2 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.Write("Tong la: " + sum);

            Console.ReadLine();
        }
    }
}
