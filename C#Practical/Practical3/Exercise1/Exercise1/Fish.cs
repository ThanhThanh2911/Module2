using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Fish : IMarineAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Fish()
        {

        }
        public Fish(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
        public void Move()
        {
            Console.WriteLine("Swim!");
        }

        public override string ToString()
        {
            return "ID:" + ID + "\nName:" + Name + "\nAge:" + Age + "\nType:" + GetType();
        }
    }
}
