using System;

namespace Bai39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Largest is: " + Math.Max(num1, Math.Max(num2, num3)));

            Console.WriteLine("Lowest is: " + Math.Min(num1, Math.Min(num2, num3)));

            Console.ReadLine();
        }
    }
}
