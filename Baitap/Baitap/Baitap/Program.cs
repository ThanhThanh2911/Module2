using System;
using System.IO;
using System.Text;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = "text.txt";
            WriteToFile(path);
            int num;
            do
            {
                Menu();
                Console.Write("Nhap cong viec: ");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        ShowMaxNumber(path);
                        break;
                    case 2:
                        ShowMinNumber(path);
                        break;
                    case 3:
                        ShowTotal(path);
                        break;
                    case 4:
                        SoftArray(path);
                        break;
                    case 5:
                        SearchInArray(path);
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            } while (num != 0);
        }

        public static void Menu()
        {
            Console.WriteLine("Cong viec: ");
            Console.WriteLine("1. Max cua mang. ");
            Console.WriteLine("2. Min cua mang.");
            Console.WriteLine("3. Tong cua mang.");
            Console.WriteLine("4. Sap xep mang.");
            Console.WriteLine("5. Tim kiem phan tu trong mang.");
            Console.WriteLine("6. Thoat. ");
        }

        private static void WriteToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Console.Write("Nhap vao do dai cua mang: ");
            int num = Int32.Parse(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                sw.Write(random.Next(1, 100)+" ");
                
                //Console.Write("Nhap vao gia tri cua phan tu[{0}]", i);
                //sw.Write(arr[i] = Int32.Parse(Console.ReadLine()));
                //sw.Write(" ");
            }
            sw.Close();
        }

        private static void ShowMaxNumber(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine().Trim();
                Console.WriteLine(line);
                string[] arr = line.Split(" ");
                int max = Int32.Parse(arr[0]);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (max< Int32.Parse(arr[i]))
                    {
                        max = Int32.Parse(arr[i]);
                    }
                }
                Console.WriteLine($"Max: {max}");
            }
        }

        private static void ShowMinNumber(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine().Trim();
                Console.WriteLine(line);
                string[] arr = line.Split(" ");
                int min = Int32.Parse(arr[0]);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (min > Int32.Parse(arr[i]))
                    {
                        min = Int32.Parse(arr[i]);
                    }
                }
                Console.WriteLine($"Max: {min}");
            }
        }

        private static void ShowTotal(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine().Trim();
                Console.WriteLine(line);
                string[] arr = line.Split(" ");
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += Int32.Parse(arr[i]);
                }
                Console.WriteLine($"Sum: {sum}");
            }
        }

        private static void SoftArray(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine().Trim();
                Console.WriteLine(line);
                string[] arr = line.Split(" ");
                string soft;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (Int32.Parse(arr[j]) < Int32.Parse(arr[i]))
                        {
                            soft = arr[i];
                            arr[i] = arr[j];
                            arr[j] = soft;
                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        private static void SearchInArray(string path)
        {
            using(StreamReader sr= new StreamReader(path))
            {
                string line = sr.ReadLine().Trim();
                Console.WriteLine(line);
                string[] arr = line.Split();
                Console.Write("Gia tri muon tim: ");
                int num = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < arr.Length; i++)
                {
                    if (num == Int32.Parse(arr[i]))
                    {
                        Console.WriteLine($"Vi tri index cua gia tri vua nhap la: {i}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay gia tri!");
                        break;
                    }
                }   
            }
        }
    }
}
