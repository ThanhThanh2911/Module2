using System;
 namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.WriteLine(num);

            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}
