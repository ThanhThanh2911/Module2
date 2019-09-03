using System;

namespace Bai19
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

            if (num1 == num2)
            {
                sum = sum * 3;
            }
            Console.WriteLine(sum);
        }
    }
}
