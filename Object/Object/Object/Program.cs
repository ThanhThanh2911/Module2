using System;

namespace Object
{
    class Person
    {
        public void Greeting()
        {
            Console.WriteLine("Hello");
        }
        int age;
        public void SetAge(int n)
        {
            age = n;
        }
        class Student : Person
        {
            public void GoToClasses()
            {
                Console.WriteLine("I'm going to class.");
            }
            public void ShowAge()
            {
                Console.WriteLine("My age is: {0} years old" ,age);
            }
        }
        class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("Explanation begins.");
            }

            private string Subject { get => Subject; set => Subject = value; }
        }
        class StudentAndTeacherTest
        {
            static void Main()
            {
                Person person = new Person();
                person.Greeting();
                Student student1 = new Student();
                student1.SetAge(21);
                student1.Greeting();
                student1.ShowAge();
                Teacher teacher1 = new Teacher();
                teacher1.SetAge(30);
                teacher1.Greeting();
                teacher1.Explain();
            }
        }
        
    }
}
