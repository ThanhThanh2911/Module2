using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int adding = num1 + num2;
            int subtracting = num1 - num2;
            int multiplying = num1 * num2;
            int dividing = num1 / num2;
            int mod = num1 % num2;

            Console.WriteLine(num1+ " + " +num2 +" = " + adding);
            Console.WriteLine(num1+ " - " +num2 +" = " + subtracting);
            Console.WriteLine(num1+ " * " + num2 + " = " + multiplying);
            Console.WriteLine(num1+ " / " + num2 + " = " + dividing);
            Console.WriteLine(num1 + " mod " + num2 + " = " + mod);

            Console.ReadLine();
        }
    }
}
