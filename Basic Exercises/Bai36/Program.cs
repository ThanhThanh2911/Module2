using System;

namespace Bai36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine((-10 < num1 && num1 < 10) && (-10 < num2 && num2 < 10));
        }
    }
}
