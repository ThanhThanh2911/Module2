using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Cat : ITerrestrialAnimal
    {
        public int ID { get ; set ; }
        public string Name { get ; set ; }
        public int Age { get ; set ; }

        public Cat()
        {

        }
        public Cat(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
        public void Move()
        {
            Console.WriteLine("Run!");
        }
        public override string ToString()
        {
            return "ID:" + ID + "\nName:" + Name + "\nAge:" + Age + "\nType:" + GetType();
        }
    }
}
