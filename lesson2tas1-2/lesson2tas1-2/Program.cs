using System;

namespace lesson2tas1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string herf1,herf2,herf3;
            Console.Write("birinci herfi yaz:");
            herf1=Console.ReadLine();
            Console.Write("ikinci herfi yaz:");
            herf2=Console.ReadLine();
            Console.Write("ucuncu herfi yaz:");
            herf3 = Console.ReadLine();
            Console.WriteLine(herf3 + herf2 + herf1);
            Console.ReadKey();

        }
    }
}
