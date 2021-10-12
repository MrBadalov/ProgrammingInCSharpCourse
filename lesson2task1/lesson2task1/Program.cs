using System;

namespace lesson2task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade, tersifade = "";
            Console.Write("bir cümlə yaz:");
            ifade = Console.ReadLine();
            for (int i = ifade.Length - 1; i >= 0; i--)//salam
                
            {
                tersifade += ifade[i];
            }

            Console.WriteLine(tersifade);
            Console.ReadKey();
        }
    }
}
