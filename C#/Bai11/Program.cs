using System;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int ages = Int32.Parse(Console.ReadLine());

            Console.WriteLine("You look older than " + ages);

            Console.ReadLine();
        }
    }
}
