using System;

namespace Lesson12_4
{
    class Program
    {
        static void Main()
        {
            Car car = new();
            int gasoline = int.Parse(Console.ReadLine());

            if (car.Refuel(gasoline))
            {
                car.Drive();
            }
            else
            {
                Console.WriteLine("Car stop");
            }
            Console.ReadKey();
        }

        public class Car : IVehicle
        {
            public bool Refuel(int gasoline)
            {
                if (gasoline <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Drive()
            {
                Console.WriteLine("Driving...");
            }
        }

        interface IVehicle
        {
            void Drive();
            bool Refuel(int gasoline);
        }
    }
}