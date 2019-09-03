using System;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "w3resource";
            Console.WriteLine("Test Data: "+ str);
            int len = str.Length - 1;
            Console.WriteLine(str.Substring(0, len));
            Console.WriteLine(str.Substring(0, len));
        }
    }
}
