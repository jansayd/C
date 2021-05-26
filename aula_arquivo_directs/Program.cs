using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace aula_arquivo_directs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                //Lista as subpastas a partir de un diretorio
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Lista os arquivos a partir de um diretorio
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                //Criar uma pasta a partir de um diretorio
                Directory.CreateDirectory(path + @"\newpath");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro Econtrado: " + e.Message);
            }
        }
    }
}
