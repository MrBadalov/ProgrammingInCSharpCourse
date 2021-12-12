using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace exam_2_1
{
    class Program
    {
        static void Main()
        {
            const string myFile = @"C:\Users\Vasif Badalov\MyFileCSharph\StudentInformation.txt";
            string newAddedStudents;


            while (true)
            {
                Thread.Sleep(2000);
                string[] lines = File.ReadAllLines(myFile);
                int n = lines.Length - 1;

                Console.WriteLine($"{lines[n - 3]}\n" +
                    $"{lines[n - 2]}\n" +
                    $"{lines[n - 1]}\n");

                newAddedStudents = File.ReadAllText(myFile);

                while (true)
                {
                    Thread.Sleep(2000);
                    if (newAddedStudents != File.ReadAllText(myFile))
                    {
                        Thread.Sleep(2000);
                        break;
                    }
                }
            }
        }
    }
}