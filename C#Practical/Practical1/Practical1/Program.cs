using System;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Int32.Parse(Console.ReadLine());
            do
            {
                Console.Write("Reenter age: ");
                age = Int32.Parse(Console.ReadLine());
            } while (age < 20);
            Console.WriteLine("Welcome to C#!");
        }
    }
}
