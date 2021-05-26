using System;

namespace aula_conversao_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a; //fazendo conversão casting

            Console.WriteLine(a);

            int w;

            w = (int)b;

            Console.WriteLine(w);

            int i = 5;
            int o = 2;

            double resultado = (double) i / o;

            Console.WriteLine(resultado);
        }
    }
}
