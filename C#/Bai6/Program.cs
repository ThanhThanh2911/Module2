using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0}x{1}x{2}={3}", num1, num2, num3, result);

            Console.ReadLine();
        }
    }
}
