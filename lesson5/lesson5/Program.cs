using System;

namespace lesson5
{
    class Program
    {
        static void Main1(string[] args)
        {
            int i;

            Console.WriteLine("The first 10 natural number are:");

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Display the sum of n odd natural number:\n");

            Console.WriteLine();

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1}", n, sum);
            Console.ReadLine();
        }

        static void Main3(string[] args)
        {

            int i, n, sum = 0;
            double avg;

            Console.WriteLine();
            Console.Write("Read 5 numbers and calculate sum and average:");

            Console.WriteLine();

            Console.WriteLine("Input the 5 numbers :");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Number-{0}:", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 5.0;
            Console.Write("The sum of 5 no is : {0}\nhe Average is : {1}\n", sum, avg);
        }

        static void Main4(string[] args)
        {
            int j, i, n;
            Console.WriteLine();
            Console.Write("Display the multiplication table vertically from 1 to n:\n");

            Console.WriteLine();

            Console.Write("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Multiplication table from 1 to {0} \n", n);
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);

                }
                Console.WriteLine();

            }



        }

        static void Main5(string[] args)
        {

            int i, j, rows;
            Console.WriteLine();
            Console.WriteLine("Display the pattern like right angle using asterisk:");

            Console.WriteLine();

            Console.Write("Input number : ");
            Console.WriteLine();
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)

                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void Main6(string[] args)
        {

            int i, j, rows, k = 1;

            Console.WriteLine();
            Console.Write("Display the pattern like right angle triangle with number increased by 1:\n");

            Console.WriteLine();

            Console.Write("Input number : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.WriteLine();
            }


        }

        static void Main7(string[] args)
        {

            int n, i, t = 9;
            int sum = 0;

            Console.WriteLine();
            Console.Write("Display the sum of the series [ 9 + 99 + 999 + 9999 ...]:\n");

            Console.WriteLine();

            Console.Write("Input number :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += t;
                Console.Write("{0}   ", t);
                t = t * 10 + 9;
            }
            Console.Write("\nThe sum of the saries = {0} \n", sum);
            Console.ReadLine();

        }

        static void Main8(string[] args)
        {

            bool Prime = true;

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Input number : ");

            Console.WriteLine("Prime Numbers between 1 to 100 : ");
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    if (a != b && a % b == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                {
                    Console.Write("\n" + a);
                }
                Prime = true;


            }
        }
        
        static void Main10(string[] args)
        {
            int number = 0;
            int nNumber = 0;
            int var = 0;
            int var1 = 0;


            Console.Write("Enter Number : ");
            nNumber = number = int.Parse(Console.ReadLine());


            while (number > 0)
            {
                var = number % 10;
                var1 = var1 * 10 + var;
                number = number / 10;

            }


            if (var1 == nNumber)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is not a Palindrome");
        }

        static void Main9(string[] args)
        {



            int n, i, var1 = 1, var2 = 1, var3 = 0, a;

            Console.WriteLine();
            Console.Write("Check whether a number can be express as sum of two prime numbers:");
            
            Console.WriteLine();


            Console.Write("Input positive integer number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 3; i <= n / 2; i++)
            {
                
                var1 = 1;
                var2 = 1;
                for (a = 2; a < i; a++)
                {
                    if (i % a == 0)
                    { var1 = 0; a = i; }
                }
                for (a = 2; a < n - i; a++)
                {
                    if ((n - i) % a == 0)
                    { var2 = 0; a = n - i; }
                }
                if (var1 == 1 && var2 == 1)
                {
                    Console.Write("{0} =  {1} + {2}  \n", n, i, n - i);
                    var3 = 1;
                }
            }
            if (var3 == 0)
            { 
                Console.Write("{0} can not be expressed as sum of two prime numbers", n); 
            }
        }








    }         
                
}
