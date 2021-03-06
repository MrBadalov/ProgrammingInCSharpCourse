using System;

namespace Lesson14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];

            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(" Message of exception : {0}", exception.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Problem");
            }

            Console.ReadKey();
        }
    }
}
