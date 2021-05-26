using System;
using System.IO;

namespace aula_arquivo_streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\temp\file.txt";
            string targetpath = @"c:\temp\file2.txt";

            try{
                string[] line = File.ReadAllLines(sourcepath);
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach(string l in line)
                    {
                        sw.WriteLine(l.ToUpper());
                    }
                }
            } catch(IOException e)
            {
                Console.WriteLine("Erro Encontrado: " + e);
            }
        }
    }
}
