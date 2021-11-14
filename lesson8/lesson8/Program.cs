using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var tmp = Console.ReadLine().Split(' ');
            int x1 = int.Parse(tmp[0]);
            int v1 = int.Parse(tmp[1]);
            int x2 = int.Parse(tmp[2]);
            int v2 = int.Parse(tmp[3]);

            float t1 = (float)(x1 - x2) / (float)(v2 - v1);
            if (t1 < 0 || t1 != Math.Floor(t1))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
