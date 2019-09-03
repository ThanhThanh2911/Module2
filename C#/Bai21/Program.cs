using System;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input first integer:");
            int num2 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine((num1 == 20 )|| (num2 == 20) || (sum == 20));
        }
    }
}
