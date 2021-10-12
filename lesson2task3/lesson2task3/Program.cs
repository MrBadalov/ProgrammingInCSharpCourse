using System;

namespace lesson2task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area, perimetr;
            Console.WriteLine("radiusu daxil edin");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            perimetr = Math.PI * 2 * radius;
            Console.WriteLine("cevrenin sahesi" + " " + area);
            Console.WriteLine("cevrenin perimetri" + " " + perimetr);
            Console.ReadKey();
        }
    }
}
