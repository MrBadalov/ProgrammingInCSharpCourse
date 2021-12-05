using System;
using System.IO;

namespace lesson13_1
{
    class Program
    {
        static void Main()
        {
            byte driveCount = 0;

            foreach (var drive in DriveInfo.GetDrives())
            {
                driveCount++;
            }

            Console.WriteLine($"This computer has {driveCount} drives\n");

            foreach (var drive in DriveInfo.GetDrives())
            {

                Console.WriteLine($"Drive name : {drive.Name}" + "\n"
                        + $"Drive label : {drive.VolumeLabel}" + "\n"
                        + $"Total size : {drive.TotalSize / 1048576} MB" + "\n"
                        + $"Used size : {(drive.TotalSize - drive.TotalFreeSpace) / 1048576} MB" + "\n"
                        + $"Total available free space : {drive.AvailableFreeSpace / 1048576} MB" + "\n"
                        + $"Total free space : {drive.TotalFreeSpace / 1048576} MB" + "\n"
                        + $"Drive Type : {drive.DriveType}");

                Console.WriteLine();
            }
        }
    }
}

