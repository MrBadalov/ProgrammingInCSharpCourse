using System;

namespace Lesson3
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("enter second number");
            int var2 = Convert.ToInt32(Console.ReadLine());



            bool a = var1 % 2 == 0 && var2 % 2 == 0;
            bool b = (var1 % 2 == 0 && var2 % 2 == 0 || var1 % 2 != 0 && var2 % 2 != 0);

            Console.WriteLine(b);

        }

        static void Main2(string[] args)
        {
            
            Console.Write("birinci sozu yaz:");
            string var1 = Console.ReadLine();

            Console.WriteLine("ikinci sozu yaz:");
            string var2 = Console.ReadLine();

            string key = "key2";
            bool keyContains = key.Contains("key1");
            Console.WriteLine(var1.Contains(var2));
            Console.ReadLine();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            double var1 = double.Parse(Console.ReadLine());



            Console.WriteLine("enter second number");
            double var2 = double.Parse(Console.ReadLine());

            Console.WriteLine(var1 / var2);

        }


    }
}
