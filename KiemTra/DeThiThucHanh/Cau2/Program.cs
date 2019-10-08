using System;
using System.Text;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập độ dài của mảng: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int num;
            do
            {
                Menu();
                Console.Write("Nhập số: ");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        CreateArray(arr, n);
                        break;
                    case 2:
                        Console.WriteLine(IsSymmetryArray(arr));
                        break;
                    case 3:
                        BubbleSort(arr);
                        break;
                    case 4:
                        Console.Write("Nhập giá trị cần tìm: ");
                        int value = Int32.Parse(Console.ReadLine());
                        Find(arr, value);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Bạn nhập sai công việc!");
                        break;
                }
            } while (num != 5);
        }

        public static void Menu()
        {
            Console.WriteLine("Công việc:");
            Console.WriteLine("1. Tạo mảng.");
            Console.WriteLine("2. Kiểm tra mảng đối xứng.");
            Console.WriteLine("3. Sắp xếp mảng.");
            Console.WriteLine("4. Tìm kiếm mảng.");
            Console.WriteLine("5. Thoát.");
        }

        public static void CreateArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Giá trị của vị trí: {i}");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static bool IsSymmetryArray(int[] arr)
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void BubbleSort(int [] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void Find(int []arr, int value)
        {
            int first = 1;
            int last = arr.Length;
            int mid ;

            while (first <= last)
            {
                mid = (first + last) / 2;
                if (arr[mid] == value)
                {
                    Console.WriteLine($"Vị trí của giá trị là: {mid}");
                    break;
                }
                else if (arr[mid] < value)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
                Console.WriteLine("Không tìm thấy!");
            }
        }
    }
}
