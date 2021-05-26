using System;
using System.Collections.Generic;

namespace aula_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Guilherme");
            list.Add("Ana");
            list.Add("Bob");
            list.Add("Maria");
            list.Add("Lucia");
            list.Add("Alberto");
            list.Insert(2, "Zé");

            Console.WriteLine("Total Itens na Lista: " + list.Count);

            foreach (string itens in list)
            {
                Console.WriteLine(itens);
            }

            string s1 = list.Find(x => x[0] == 'A'); //função lambda
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); //função lambda
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); //função lambda
            Console.WriteLine("First position index 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //função lambda
            Console.WriteLine("Last position index 'A': " + pos2);

            //Filtrar itens de uma Lista
            List<string> list_filter = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------------");
            foreach(string itens2 in list_filter)
            {
                Console.WriteLine(itens2);
            }

            //Remover Itens ds Lista
            list.Remove("Alberto");
            Console.WriteLine("--------------------------------------");
            foreach (string itens2 in list)
            {
                Console.WriteLine(itens2);
            }

            //Remover todos os iens que começam com a Letra M
            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("--------------------------------------");
            foreach (string itens2 in list)
            {
                Console.WriteLine(itens2);
            }

            //Remover Itens ds Lista por Index
            list.RemoveAt(0);
            Console.WriteLine("--------------------------------------");
            foreach (string itens2 in list)
            {
                Console.WriteLine(itens2);
            }

            //Remover Itens ds Lista por range de index
            list.RemoveRange(2 , 2);
            Console.WriteLine("--------------------------------------");
            foreach (string itens2 in list)
            {
                Console.WriteLine(itens2);
            }
        }
    }
}
