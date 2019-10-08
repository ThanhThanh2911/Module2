using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Array();
            List();
        }

        public static void Array()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            Random random = new Random();
            int[] arr1 = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr1[i] = random.Next(1, 100);
            }
            st.Stop();
            Console.WriteLine("Thời gian tạo mảng {0} giây", st.Elapsed.ToString());
            st.Reset();

            st.Start();
            int temp;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = 0; j < arr1.Length - 1; j++)
                {
                    if (arr1[j + 1] < arr1[j])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;

                    }
                }
            }
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            st.Stop();
            Console.WriteLine("Thời gian sắp xếp mảng {0} giây", st.Elapsed.ToString());

            //In số lần xuất hiện của 1 phần tử.
            int dem = 0;
            Console.Write("Nhập giá trị cần tìm: ");
            int num = Int32.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (num == arr1[i])
                {
                    check = true;
                    dem++;
                }
            }
            if (!check)
            {
                Console.WriteLine($"KHÔNG TÌM THẤY PHẦN TỬ");
            }
            else
            {
                Console.WriteLine($"Số lần xuất hiện của {num} là { dem}");
            }

            // Xóa theo vị trí index.
            Console.Write("Nhập vị trí muốn xóa trong mảng: ");
            int index1 = Int32.Parse(Console.ReadLine());
            int a ,b;
            bool check1 = false;
            for (a = b = 0; b < arr1.Length; b++)
            {
                if (index1 != b)
                {
                    check1 = true;
                    arr1[a] = arr1[b];
                    a++;
                }
            }
            if(check1 == false)
            {
                Console.WriteLine("Nhập sai vị trí index!");
            }
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            //Thêm phần tử theo chỉ số index
            Console.Write("Nhập vị trí muốn thêm trong mảng: ");
            int index2 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị muốn thêm trong mảng: ");
            int giaTri = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= index2; i++)
            {
                arr1[i + 1] = arr1[i];               
            }
            arr1[index2 - 1] = giaTri;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }

        public static void List()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(1, 100);
                list.Add(num);
            }
            watch.Stop();
            Console.WriteLine($"Thời gian tạo List: {watch.Elapsed} giây");
            watch.Reset();

            watch.Start();
            int size = list.Count;
            int temp;
            for (int i = 0; i < size -1 ; i++)
            {
                for (int j = 0; j < size -1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }                   
                }
            }
            watch.Stop();
            Console.WriteLine($"Thời gian sắp xếp List: {watch.Elapsed} giây");

            //xóa phần tử trong mảng
            Console.WriteLine("Nhập vị trí muốn xóa trong list: ");
            int index = Int32.Parse(Console.ReadLine());
            int length = list.Count;
            bool check = false;
            for (int i = length -1; i >= 0; i--)
            {
                if (index == i)
                {
                    check = true;
                    list.Remove(list[i]);
                }                   
            }
            if (check == false)
            {
                Console.WriteLine("Nhập sai vị trí trong list!");
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
