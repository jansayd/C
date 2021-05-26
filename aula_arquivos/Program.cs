using System;
using System.IO;

namespace aula_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string l in lines)
                {
                    Console.WriteLine(l);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error file: " + e.Message);
            }
        }
    }
}
