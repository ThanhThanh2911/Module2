using System;

namespace Bai35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num1 < 100 && num2 > 100);
        }
    }
}
