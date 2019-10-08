using System;
using System.Text;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số hàng: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số hàng: ");
            int m = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            CreateMatrix(arr, n, m);
            FindMax(arr, n, m);
            ShowMatrix(arr, n, m);
        }

        public static void CreateMatrix(int [,]arr, int n, int m)
        {
            Random random = new Random();            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = random.Next(1, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Vị trí [{0},{1}]: {2}", i, j, arr[i, j]); 
                }
            }
        }

        public static void FindMax(int[,]arr, int n, int m)
        {
            int max = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine("Số lớn nhất trong mảng là: {0}",max);
        }
        public static void ShowMatrix(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}  ", arr[i, j]);         
                }
                Console.Write("\n");
            }

            Console.WriteLine("Ma trận tam giác dưới");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                    if (i >= j)
                        Console.Write("{0}  ", arr[i, j]);
                    else
                        Console.Write("{0}  ", " ");
            }
        }
    }
}
