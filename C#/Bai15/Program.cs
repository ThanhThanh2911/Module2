using System;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "w3resource";
            Console.WriteLine("Test Data: " + str);
            Console.WriteLine(str.Remove(1, 1));
            Console.WriteLine(str.Remove(9, 1));
            Console.WriteLine(str.Remove(0, 1));
        }
    }
}
