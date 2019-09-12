using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 1;

            //use for
            //for (int i = 1; i<=n; i++)
            //{
            //    sum = sum * i;
            //}
            //Console.WriteLine("n! = {0}", sum);

            //use while
            //while (i <= n)
            //{
            //    sum = sum * i;
            //    i++;
            //}
            //Console.WriteLine("n! = {0}", sum);

            //use do-while
            //do
            //{
            //    sum = sum * i;
            //    i++;
            //} while (i <= n);
            //Console.WriteLine("n! = {0}", sum);

            // use recursion
            double result = giaithua(n);
            Console.WriteLine("n! = {0}", result);
        }
        private static double giaithua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * giaithua(n - 1);
            }
        }
    }
}


