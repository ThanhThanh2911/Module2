using System;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input first integer:");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));
            
        }
    }
}
