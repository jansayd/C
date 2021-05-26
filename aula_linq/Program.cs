using System;
using System.Linq;

namespace aula_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //especificando o Data Source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //definindo a query
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //executar a query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
