using System;

namespace lesson2task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ad, soyad;
            Console.WriteLine("AD:");
            Ad = Console.ReadLine();

            Console.WriteLine("SOYAD:");
            soyad = Console.ReadLine();
            Console.WriteLine(Ad + soyad);
            Console.WriteLine(Ad.ToUpper());
            Console.WriteLine(soyad.ToUpper());
        }
    }
}
