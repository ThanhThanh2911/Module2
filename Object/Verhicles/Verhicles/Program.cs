using System;
using System.Collections.Generic;
using System.Text;

namespace Verhicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Car> Cars = new List<Car>();
            List<Bike> Bikes = new List<Bike>();
            int num;
            do
            {
                Menu();
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Write("Enter the number of bike: ");
                        int n = Int32.Parse(Console.ReadLine());
                        Bike bike1;
                        for (int i = 0; i < n; i++)
                        {
                            bike1 = new Bike();
                            Console.WriteLine("ID: {0}", i + 1);
                            Console.Write("Speed: ");
                            bike1.Speed = Int32.Parse(Console.ReadLine());
                            Console.Write("Make: ");
                            bike1.Make = Console.ReadLine();
                            Console.Write("Model: ");
                            bike1.Model = Console.ReadLine();
                            Console.Write("Year: ");
                            bike1.Year = Console.ReadLine();
                            Bikes.Add(bike1);
                        }
                        break;
                    case 2:
                        foreach (var vehicle in Bikes)
                        {
                            Console.WriteLine(vehicle.ToString());
                        }
                        break;
                    case 3:
                        Console.Write("Enter the number of the car: ");
                        int m = Int32.Parse(Console.ReadLine());
                        Car car1;
                        for (int i=0; i<m; i++)
                        {
                            car1 = new Car();
                            Console.WriteLine("ID: {0}", i + 1);
                            Console.Write("Speed: ");
                            car1.Speed = Int32.Parse(Console.ReadLine());
                            Console.Write("Make: ");
                            car1.Make = Console.ReadLine();
                            Console.Write("Model: ");
                            car1.Model = Console.ReadLine();
                            Console.Write("Year: ");
                            car1.Year = Console.ReadLine();
                            Cars.Add(car1);
                        }
                        
                        break;
                    case 4:
                        foreach (var car in Cars)
                        {
                            Console.WriteLine(car.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Đã thoát chương trình!");
                        break;
                    default:
                        Console.WriteLine("Bạn đã nhập sai!");
                        break;
                }
            }
            while (num != 5);

            
            
        }
        private static void Menu()
        {
            Console.WriteLine("Chọn Công Việc:");
            Console.WriteLine("1=> Nhập số lượng xe đạp: ");
            Console.WriteLine("2=> Hiện danh sách xe đạp: ");
            Console.WriteLine("3=> Nhập số lượng xe ô tô: ");
            Console.WriteLine("4=> Hiện danh sách xe đạp: ");
            Console.WriteLine("5=> Thoát khỏi chương trình: ");

        }
    }
}
