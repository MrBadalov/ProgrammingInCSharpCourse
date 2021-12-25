using System;
using System.Linq;
using System.Collections.Concurrent;
using Microsoft.CSharp;
using System.Collections;
using System.Collections.Generic;

namespace lessson17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = UserManager.ListOfUsers();

            UserManager.ListOfCountry printUsers = UserManager.printUsers;

            printUsers(list.Where(u => u.Age > 20).ToList());

            var UsersTurkishLowerAge10 = list.Where(u => (u.Age > 10) || (u.Country != "Turkey"))
                .ToList();

        }
    }

    public class User
    {
        public User(string name, string surname, int age, string country)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age} {Country}";
        }


    }

    public static class UserManager
    {

        public static List<User> ListOfUsers()
        {
            return new List<User>()
            {
            new User("Ilqar", "Badalov", 38, "Azerbaijan"),
            new User("Yaman", "Baysun", 21, "Turkey"),
            new User("Samir", "Allazov", 28, "Azerbaijan"),
            new User("Halil", "Umut", 7, "Turkey"),
            new User("Emre", "Belezoglu", 25, "Turkey"),
            
            };
        }


        public delegate void ListOfCountry(List<User> list);
        public static void printUsers(List<User> list)
        {
            foreach (var u in list)
            {
                Console.WriteLine(u.ToString());
            }
        }
    }
}

