using System;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);

            Console.ReadLine();
        }
    }
}
