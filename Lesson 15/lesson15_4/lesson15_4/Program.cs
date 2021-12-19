using System;
using System.Collections.Generic;

namespace lesson15_4
{
    internal class Program
    {

        static void Main()
        {
            List<string> processToKill = new List<string>(3);

            List<string> process = new();

            process.Add("Explorer.exe");
            process.Add("Windows.exe");
            process.Add("Something.exe");


            foreach (var kill in process)
            {
                if (kill != "Explorer.exe")
                {
                    processToKill.Add(kill);
                }
            }

            foreach (var kill in processToKill)
            {
                Console.WriteLine(kill);
            }

            Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));
            Console.WriteLine(string.Format("Count {0}", processToKill.Count));
        }
    }
}





