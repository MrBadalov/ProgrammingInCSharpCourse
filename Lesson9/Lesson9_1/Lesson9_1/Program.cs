﻿using System;

namespace Lesson9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                persons[i] = new Person();
                persons[i].Name = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            
        }
    }
    class Person
    {
        public string Name;
        public string ToString()
        {
            return "Hello my name is " + Name;
        }
    }
}
