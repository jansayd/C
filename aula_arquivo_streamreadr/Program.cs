using System;
using System.IO;

namespace aula_arquivo_streamreadr
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro Econtrado: " + e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
