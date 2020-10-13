using System;
using System.IO;

namespace ShowFilesDemo
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            try
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine("File: {0}", file.FullName);
                }

                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    ShowDirectory(subDir);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Для доступа к папке нужны права администратора");
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory);
            ShowDirectory(dir);
        }
    }
}

