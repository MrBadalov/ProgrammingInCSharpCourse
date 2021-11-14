using System;

namespace lesson9_5
{
    class Program
    {



        public static void Main(string[] args)
        {
            
            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }



    }


    public class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }


    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }



    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}
