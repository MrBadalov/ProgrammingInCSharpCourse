using System;
using System.Collections.Generic;

namespace lesson15_3
{
    internal class Program
    {
        public static void Main()
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            people.Add("Kamran", 27);
            people.Add("Vasif", 28);
            var one = people.GetEnumerator();
            one.MoveNext();
            var currentItem = one.Current;



            foreach (var key in people.Keys)
            {
                Console.WriteLine( key);
                break;
            }
            Console.ReadKey();
        }
    }
}