using System;
using System.IO;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Vasif Badalov\MyFileCSharph");
            FileInfo[] files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            Console.WriteLine("The count of files and directories is : {0}", files.Length.ToString());
            Console.ReadKey();
        }
    }
}