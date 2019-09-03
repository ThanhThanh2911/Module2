using System;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int mul;

            for (int i=1; i<=10; i++)
            {
                mul = num * i;
                Console.WriteLine(num + "x" + i + "=" + mul);
            }

            Console.ReadLine();
        }
    }
}
