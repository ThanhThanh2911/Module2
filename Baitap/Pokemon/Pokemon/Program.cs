using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Pokemon
{
    class Program
    {
        public static List<Pokemon> listPokemon = new List<Pokemon>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num;
            Pokemon pokemon1 = new Pokemon();
            do
            {
                Menu();
                Console.WriteLine("Nhap so: ");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin pokemon:");
                        AddPokemon(pokemon1);
                        break;
                    case 2:
                        ShowPokemon();
                        break;
                    case 3:
                        Console.Write("Nhập tên cần tìm: ");
                        string name = Console.ReadLine();
                        SearchPokemon(name);
                        break;
                    case 4:
                        Console.Write("ID: ");
                        int id = Int32.Parse(Console.ReadLine());
                        EditInfoPokemon(id);
                        break;
                    case 5:
                        ShowSpeak();
                        break;
                    case 6:
                        ShowNameAndRate();
                        break;
                    case 7:
                        WriteToFile();
                        break;
                    case 8:
                        break;
                    case 9:
                        Console.WriteLine("Ban da thoat khoi chuong trinh!");
                        return;
                    default:
                        break;
                }
            } while (num != 9);
        }

        private static void ShowSpeak()
        {
            throw new NotImplementedException();
        }

        private static void WriteToFile()
        {
            int size = listPokemon.Count; 
            for (int i = 0; i < size; i++)
            {
                StreamWriter sw = new StreamWriter(@"D:\Pokemon\"+(i+1)+".TXT");
                sw.WriteLine("Thong tin Pokemon:");
                foreach (var item in listPokemon)
                {
                    sw.WriteLine(item.Name);
                    sw.WriteLine(item.Type);
                    sw.WriteLine(item.TypePokemon());
                    sw.WriteLine(item.Height);
                    sw.WriteLine(item.Weight);
                    sw.WriteLine(item.HP);
                    sw.WriteLine(item.Attack);
                    sw.WriteLine(item.Defence);
                    sw.WriteLine(item.Speed);
                }
                sw.Close();
            }
        }

        private static void ShowNameAndRate()
        {
            foreach (var item in listPokemon)
            {
                Console.WriteLine(item.Name);
                item.RaitingPokemon();
            }
        }

        private static void EditInfoPokemon(int id)
        {
            Console.Write("Nhap vao ID pokemon: ");
            id = Int32.Parse(Console.ReadLine());
            foreach (var item in listPokemon)
            {
                if (id == item.ID)
                {
                    Console.Write("Name: ");
                    item.Name = Console.ReadLine();
                    Console.WriteLine("Type: ");
                    item.TypePokemon(); 
                    Console.Write("Height: ");
                    item.Height = Int32.Parse(Console.ReadLine());                   
                    Console.Write("Weight: ");
                    item.Weight = Int32.Parse(Console.ReadLine());
                    do
                    {
                        Console.Write("HP: ");
                        item.HP = Int32.Parse(Console.ReadLine());

                    } while (item.HP < 0 || item.HP > 5000);
                    Console.Write("Attack: ");
                    item.Attack = Int32.Parse(Console.ReadLine());
                    Console.Write("Defence: ");
                    item.Defence = Int32.Parse(Console.ReadLine());
                    Console.Write("Speed: ");
                    item.Speed = Int32.Parse(Console.ReadLine());
                    listPokemon.Add(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Khong tim thay ID phu hop!");
                    break;
                }
            }
        }

        private static void SearchPokemon(string name)
        {
            Console.Write("Nhap ten pokemon: ");
            name = Console.ReadLine();
            foreach (var item in listPokemon)
            {
                if(name == item.Name)
                {
                    item.ViewInfo();
                }
                else
                {
                    Console.WriteLine("Khong tim thay pokemon!");
                    break;
                }
            }
        }

        private static void ShowPokemon()
        {
            foreach (var item in listPokemon)
            {
                item.ViewInfo();
            }
        }

        private static void AddPokemon(Pokemon pokemon)
        {
            Console.Write("Nhap ten pokemon: ");
            pokemon.Name = Console.ReadLine();
            Console.WriteLine("Chon he pokemon: ");
            pokemon.TypePokemon();
            Console.Write("Nhap chieu cao cua pokemon: ");
            pokemon.Height = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap can nang cua pokemon: ");
            pokemon.Weight = Int32.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap chi so HP cua pokemon: ");
                pokemon.HP = Int32.Parse(Console.ReadLine());
            } while (pokemon.HP < 0 || pokemon.HP > 5000);
            Console.Write("Nhap chi so tan cong cua pokemon: ");
            //pokemon.Attack = Int32.Parse(Console.ReadLine());
            try
            {
                pokemon.Attack = Int32.Parse(Console.ReadLine());
                pokemon.SetAttactDefenceSpeed(pokemon.Attack);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Bạn đã nhập sai kiểu dữ liệu");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Bạn đã nhập ngoài vùng dữ iệu cho phép!");
            }           
            Console.Write("Nhap chi so phong thu cua pokemon: ");
            pokemon.Defence = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap toc do cua pokemon: ");
            pokemon.Speed = Int32.Parse(Console.ReadLine());
            listPokemon.Add(pokemon);
        }

        public static void Menu()
        {
            Console.WriteLine("Chon cong viec: ");
            Console.WriteLine("1. Tao 1 con pokemon va add vao list. ");
            Console.WriteLine("2. Show thong tin cua tat ca pokemon. ");
            Console.WriteLine("3. Nhap ten hoac ID cua pokemon, roi show thong tin cua pokemon do. ");
            Console.WriteLine("4. Yeu cau chinh sua thong tin pokemon dua vao ID nhap vao. ");
            Console.WriteLine("5. Show tat ca tieng keu cua tat ca pokemon trong list. ");
            Console.WriteLine("6. Trả về tên pokemon và đánh giá rating có trong List. ");
            Console.WriteLine("7. Thực hiện ghi ra file mỗi pokemon 1 file. Thư mục lưu trữ file ở ổ đĩa D:/pokemon ");
            Console.WriteLine("8. Thực hiện tạo 1 list Pokemon thực hiện đọc file các pokemon trong thư mục, add vào list ");
            Console.WriteLine("9. Thoat. ");
        }
    }
}
