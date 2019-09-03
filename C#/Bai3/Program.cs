using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int num2 = Int32.Parse(Console.ReadLine());
            int dividing = num1 / num2;
            Console.Write("Thuong hai so la: " + dividing);

            Console.ReadKey();
        }
    }
}
