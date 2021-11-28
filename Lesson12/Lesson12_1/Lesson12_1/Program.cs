using System;
using System.IO;

namespace Lesson12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Vasif Badalov\MyFileCSharph";

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (var directory in directories)
            {
                Directory.Delete(directory);
            }

            foreach (var file in files)
            {
                switch (Path.GetExtension(file))
                {
                    case ".jpg":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Images", true);
                        break;
                    case ".mp3":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Musics", true);
                        break;
                    case ".mp4":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Videos", true);
                        break;
                    case ".txt":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Documents", true);
                        break;
                    case ".xlsx":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Documents", true);
                        break;
                    case ".pptx":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Documents", true);
                        break;
                    case ".docx":
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Documents", true);
                        break;
                    default:
                        File.Move(file, @"C:\Users\Vasif Badalov\MyFileCSharph\Others", true);
                        break;
                }
            }
        }






    }

}