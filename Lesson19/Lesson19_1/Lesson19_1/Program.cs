using System;
using System.Threading;

namespace Lesson19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread program1Runner = new Thread(() => Program1(100));
            program1Runner.Start();

            Thread program2Runner = new Thread(() => Program2(100));
            program2Runner.Start();

            Console.ReadKey();
        }

        static void Program1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nprogram1 " + i);

                Thread.Sleep(20);
            }
        }
        

        static void Program2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nprogram2 " + i);

                Thread.Sleep(20);
            }
        }
    }
}
