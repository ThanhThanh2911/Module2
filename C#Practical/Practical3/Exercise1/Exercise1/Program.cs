using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Exercise1
{
    class Program
    {
        private static int tempID = 1;
        static List<IAnimal> listAnimal = new List<IAnimal>();
        static List<ITerrestrialAnimal> listTerrestrialAnimal = new List<ITerrestrialAnimal>();
        static List<IMarineAnimal> listMarineAnimal = new List<IMarineAnimal>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num;
            do
            {
                Menu();
                Console.Write("\t\tCHON EM NÀO: ");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        NewCroCodile();
                        break;
                    case 2:
                        NewCat();                       
                        break;
                    case 3:
                        NewFish();
                        break;
                    case 4:
                        foreach (var animal in listTerrestrialAnimal)
                        {
                            Console.WriteLine(animal.ToString());
                            animal.Move();
                        }
                        break;
                    case 5:
                        foreach (var animal in listMarineAnimal)
                        {
                            Console.WriteLine(animal.ToString());
                            animal.Move();
                        }
                        break;
                    case 6:
                        foreach (var animal in listAnimal)
                        {
                            Console.WriteLine(animal.ToString()) ;
                            //animal.Move();
                        }
                        break;
                    case 7:
                        Remove();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Bạn nhập sai rồi!");
                        break;
                }

            } while (num != 0);
        }

        private static void NewFish()
        {
            Fish fish = new Fish();
            Console.Write("Tuổi con cá: ");
            fish.Age = Int32.Parse(Console.ReadLine());
            Console.Write("Tên con cá: ");
            fish.Name = Console.ReadLine();
            fish.ID = tempID;
            listAnimal.Add(fish);
            listMarineAnimal.Add(fish);
            tempID++;
        }

        private static void NewCat()
        {
            Cat cat = new Cat();
            Console.Write("Tuổi con mèo: ");
            cat.Age = Int32.Parse(Console.ReadLine());
            Console.Write("Tên con mèo: ");
            cat.Name = Console.ReadLine();
            cat.ID = tempID++;
            listAnimal.Add(cat);
            listTerrestrialAnimal.Add(cat);
        }

        private static void NewCroCodile()
        {
            Crocodile croCodile = new Crocodile();
            Console.Write("Tuổi con cá sấu: ");
            croCodile.Age = Int32.Parse(Console.ReadLine());
            Console.Write("Tên con cá sấu: ");
            croCodile.Name = Console.ReadLine();
            croCodile.ID = tempID++;
            listAnimal.Add(croCodile);
            listTerrestrialAnimal.Add(croCodile);
            listMarineAnimal.Add(croCodile);
        }

        private static void Remove()
        {
            Console.Write("Nhập vào ID con vật: ");
            int id = Int32.Parse(Console.ReadLine());
            int length = listAnimal.Count;
            for (int i = 0; i < length; i++)
            {
                if (id == listAnimal[i].ID)
                {
                    listAnimal.Remove(listAnimal[i]);
                    break;
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Chọn công việc: ");
            Console.WriteLine("1. Tạo con cá sấu.");
            Console.WriteLine("2. Tạo con mèo.");
            Console.WriteLine("3. Tạo con cá.");
            Console.WriteLine("4. Hiện thị con vật trên cạn.");
            Console.WriteLine("5. Hiện thị con vật dưới nước.");
            Console.WriteLine("6. Hiển thị tất cả con vật.");
            Console.WriteLine("7. Xóa con vật");
            Console.WriteLine("8. Thoát. ");

        }       
    }    
}
