using System;

namespace lesson6
{
    class Program
    {
        static void Main1(string[] args)
        {
            Random var = new Random();

            Console.WriteLine("Enter random number (1 - 100): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] rand = new int[n];
            for (int i = 0; i < n; i++)
            {
                rand[i] = var.Next(1, 100);
            }

        }

        static void Main123(string[] args)
        {
            // 1st task 


            Random var = new();

            Console.WriteLine("Enter random numbers(1 to 100): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeration = new int[n];

            for (int i = 0; i < n; i++)
            {
                numeration[i] = var.Next(1, 101);
            }

            Console.WriteLine("Sorted in ascending order of random numbers\n");

            Array.Sort(numeration);

            foreach (int item in numeration)
            {
                Console.WriteLine(item);
            }

            Console.Write("\n\nSorted in descending order of random numbers\n\n");

            Array.Reverse(numeration);

            foreach (int item in numeration)
            {
                Console.WriteLine(item);

            }

            // 2nd task

            Console.WriteLine("The 3rd max element of array is " + numeration[2] );

            //3rd task

            Console.WriteLine("the first 4 max elements :");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numeration[i]);
            }
        }

        //task4
        static void Main4(string []args)
        {
            int num1, num2;
            Console.WriteLine("to swap the values of two integer numbers without additional variable : ");
            Console.WriteLine();
            Console.WriteLine("enter 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            change(num1, num2);
            Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}", num1, num2);

        }
        public static void change(int num1, int num2)
        {
            int var1;

            var1 = num1;
            num1 = num2;
            num2 = var1;

        }
       //task5
        static void Main5(string [] args)
        {

            int num1 = 0, num2 = 1, num3, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                
                Console.Write(num1 + " " + num2 + " ");
                
                for (int i = 2; i < numberOfElements; i++)
                {
                    num3 = num1 + num2;
                    Console.Write(num3 + " ");
                    num1 = num2;
                    num2 = num3;
                }
            }

            Console.ReadKey();

        }
        //task6
        static void Main6(string[] args)
        {

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("The sum of the digits of the number : " + sum);


        }
        
        

            public static int SpaceCount(string str)
            {
                int count = 0;
                string str1;
                for (int i = 0; i < str.Length; i++)
                {
                    str1 = str.Substring(i, 1);
                    if (str1 == " ")
                        count++;
                }
                return count;
            }

        //task7
            public static void Main7()
            {
                string str2;
                Console.Write("\n\nFunction to count number of spaces in a string :\n");
                
                Console.Write("input a string : ");
                str2 = Console.ReadLine();
                Console.WriteLine(" " + " str2" + " " + " contains {0} spaces", SpaceCount(str2));
            }
        
    }
}
