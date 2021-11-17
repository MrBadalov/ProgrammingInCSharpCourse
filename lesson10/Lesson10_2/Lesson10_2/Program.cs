using System;

namespace Lesson10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolPerson schoolPerson = new SchoolPerson();
            schoolPerson.Greet();
            Console.WriteLine("____________");

            Student student = new Student();
            student.Age = 21;
            student.Greet();
            student.ShowAge();
            student.GoToClasses();
            Console.WriteLine("____________");

            Teacher teacher = new Teacher();
            teacher.Age = 30;
            teacher.Greet();
            teacher.GoToClasses();
            teacher.Explain();
        }
    }
    

    public class SchoolPerson
    {
        private int _age;
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 6 && value < 50)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("you have entered the wrong age");
                }
            }
        }
        public void Greet()
        {
            Console.WriteLine($"Hello {Name} {Surname}");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is  {Age}");
        }
        public void GoToClasses()
        {
            Console.WriteLine("I am going to class.");
        }
    }

    public class Student : SchoolPerson
    {
        public new void GoToClasses()
        {
            Console.WriteLine($"I’m {Name} {Surname}, I am student and I'm going to class.");
        }
    }

    public class Teacher : SchoolPerson
    {
        public void Explain()
        {
            Console.WriteLine("Explanation begin on subject.");
        }

        public new void GoToClasses()
        {
            Console.WriteLine($"I’m {Name} {Surname}, I am a teacher.");
        }
    }
}
