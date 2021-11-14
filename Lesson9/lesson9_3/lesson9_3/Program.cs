using System;

namespace lesson9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            Console.WriteLine();

            student student = new student();
            student.SetAge(27);
            student.Greet();
            student.ShowAge();
            student.study();
            Console.WriteLine();


            teacher teacher = new teacher();
            teacher.SetAge(29);
            teacher.Greet();
            teacher.Explain();


        }
    }

    public class Person
    {

        public void Greet()
        {
            Console.WriteLine("Hello ");
        }
        public int age;
        public void SetAge(int n)
        {
            age = n;
        }

    }
    public class student: Person
    {
        public void study()
        {
            Console.WriteLine("I m studying");

        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} year old ", age);
        }
    }
    public class teacher: Person
    {
        public void Explain()
        {
            Console.WriteLine("I m explainning");
        }
    }
}
