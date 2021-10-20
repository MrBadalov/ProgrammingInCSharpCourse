using System;

namespace lesson4
{
    class Program
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("enter birth day");

            DateTime birtdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(birtdate.DayOfWeek);

            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            DateTime date1 = DateTime.Now;
            DateTime birtdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(birtdate);
            TimeSpan timerenge = date1 - birtdate;
            Console.WriteLine(timerenge);
            Console.ReadLine();
        }

        static void Main3(string[] args)
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1.Add(TimeSpan.Parse("40.00:00:00")));
            Console.WriteLine(date1.DayOfWeek);
        }

        

        static void Main5(string[] args)
        {

            Console.WriteLine("Enter a day number:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a month number:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a year number:");
            int year = int.Parse(Console.ReadLine());

            DateTime Date = new DateTime(year, month, day);
            string date1 = Date.ToString("dd/MM/yyyy");

            Console.WriteLine(date1);
            Console.WriteLine("31/12/" + year);

        }

        static void Main6(string[] args)
        {
            Console.WriteLine("Enter a day");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a month");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            string formatdate = inputDate.ToString("dd/MM/yyyy");

            DayOfWeek dayOfWeek = inputDate.DayOfWeek;

            Console.WriteLine("Format Date:" + inputDate);

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                
                default:
                    Console.WriteLine("Not day of week");
                    break;
            }
            static void Main7(string[] args)
            {

                int a1, a2, a3;

                Console.WriteLine("1-ci reqem daxil edin:");
                a1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2-ci reqem daxil edin:");
                a2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("3-cu reqem daxil edin:");
                a3 = Convert.ToInt32(Console.ReadLine());

                if (a1 >= a2 && a1 >= a3)
                {
                    Console.WriteLine("The 1st number is the greatest among three");
                }
                else if (a2 > a1 && a2 > a3)
                {
                    Console.WriteLine("The 2st number is the greatest among three");
                }

                else
                {
                    Console.WriteLine("The 3st number is the greatest among three");
                }


                Console.ReadLine();


            }
        }
        

            static void Main8(string[] args)
            {

                DateTime date1 = new DateTime();

                Console.WriteLine("input number");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Wrong Number");
                        break;
                }

                Console.ReadLine();
            }
        static void Main(string[] args)
        {

            Console.WriteLine(" enter first number");
            int var1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int var2 = int.Parse(Console.ReadLine());

            Console.WriteLine("select one");
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Substraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-division");
            Console.WriteLine("5-exit");

            byte colculations = byte.Parse(Console.ReadLine());

            switch (colculations)
            {
                case 1:
                    Console.WriteLine(var1 + var2);
                    break;
                case 2:
                    Console.WriteLine(var1 - var2);
                    break;
                case 3:
                    Console.WriteLine(var1 * var2);
                    break;
                case 4:
                    Console.WriteLine(var1 / var2);
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }

        }

    }
}
