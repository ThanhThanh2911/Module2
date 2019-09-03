using System;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Int32.Parse(Console.ReadLine());

            double kelvin = celsius + 273.15;
            Console.WriteLine("Kelvin = "+ kelvin);

            double fahrenheit = celsius*1.8 + 32;
            Console.WriteLine("Fahrenheit = " + fahrenheit);

            Console.ReadLine();
        }
    }
}
