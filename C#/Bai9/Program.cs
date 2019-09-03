using System;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Four number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of"+ num1 + "," + num2 + "," + num3 + "," + num4  +"is:" + average);

            Console.ReadLine();
        }
    }
}
