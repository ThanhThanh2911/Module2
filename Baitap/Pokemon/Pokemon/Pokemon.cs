using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class Pokemon
    {
        private static int tempId = 1;
        private int iD;
        private string name;
        private string type;
        private double height;
        private double weight;
        private int hP;
        private int attack;
        private int defence;
        private int speed;
        List<string> listType = new List<string>();

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public int HP { get => hP; set => hP = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Speed { get => speed; set => speed = value; }

        public Pokemon()
        {
            ID = tempId++;
        }

        public Pokemon(int id,  string name, string type, double height, double weight,
            int hP, int attack, int defence, int speed)
        {
            ID = id;
            Name = name;
            Type = type;
            Height = height;
            Weight = weight;
            HP = hP;
            Attack = attack;
            Defence = defence;
            Speed = speed;
        }

        public void SetAttactDefenceSpeed(int attact)
        {
            if(0< attack && attack <= 100)
            {
                Attack = attact;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public string TypePokemon()
        {
            int chon;
            while(true)
            {
                Console.WriteLine("Chọn hệ:");
                Console.WriteLine("1. Normal.  2. Water.  3. Grass.  4. Fire.  5. Electric.  6. Ghost.");
                Console.WriteLine("7. Dragon.  8. Rock.   9. Ice.    10. Bug.  11. Postion.  12. Xong.");
                Console.WriteLine("Chọn số: ");
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        listType.Add("Normal");
                        break;
                    case 2:
                        listType.Add("Water");
                        break;
                    case 3:
                        listType.Add("Grass");
                        break;
                    case 4:
                        listType.Add("Fire");
                        break;
                    case 5:
                        listType.Add("Electric");
                        break;
                    case 6:
                        listType.Add("Ghost");
                        break;
                    case 7:
                        listType.Add("Dragon");
                        break;
                    case 8:
                        listType.Add("Rock");
                        break;
                    case 9:
                        listType.Add("Ice");
                        break;
                    case 10:
                        listType.Add("Bug");
                        break;
                    case 11:
                        listType.Add("Postion");
                        break;
                    //case 12:
                    //    Console.WriteLine("Bạn đã chọn xong thuộc tính!");
                    //    //return;
                    default:
                        break;
                }
            }
        }

        
        public void ViewInfo()
        {
            Console.WriteLine($"ID cua pokemon: {ID}");
            Console.WriteLine($"Ten cua pokemon: {Name}");
            Console.WriteLine($"He cua pokemon: {Type}");
            foreach (var item in listType)
            {
                Console.Write  (item +" \t ");
            }
            Console.WriteLine($"Chieu cao cua pokemon: {Height}");
            Console.WriteLine($"Can nang cua pokemon: {Weight}");
            Console.WriteLine($"Chi so mau cua pokemon: {HP}");
            Console.WriteLine($"Chi so tan cong cua pokemon: {Attack}");
            Console.WriteLine($"Chi so phong thu cua pokemon: {Defence}");
            Console.WriteLine($"Toc do cua pokemon: {Speed}");    

        }

        public void Sound(string sound)
        {
            Console.WriteLine(sound);
        }

        public void RaitingPokemon()
        {
            double average;
            average = (Attack + Defence + Speed) /3;
            if (average >= 90)
            {
                Console.WriteLine("Perfect!");
            }
            else if(60 <= average && average < 80)
            {
                Console.WriteLine("Good!");
            }
            else if (40 <= average && average < 60)
            {
                Console.WriteLine("Medium!");
            }
            else if (0 <= average && average < 60)
            {
                Console.WriteLine("Bad!");
            }
        }
    }
}
