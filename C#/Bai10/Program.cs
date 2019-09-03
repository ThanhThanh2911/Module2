using System;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int result1 = (x + y)*z;
            int result2 = x*y + y*z;

            Console.WriteLine("(x + y).z =" + result1 + " and " + "x.y + y.z =" + result2);

            Console.ReadLine();
        }
    }
}
