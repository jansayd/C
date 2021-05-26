using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio_funcionario_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int qtde_func = int.Parse(Console.ReadLine());

            List<Funcionario> list_func = new List<Funcionario>(); 

            for(int x = 0; x < qtde_func; x++)
            {
                Console.Write("ID do Funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome do Funcionario: ");
                string nome = Console.ReadLine();
                Console.Write("Salario do Funcionario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list_func.Add(new Funcionario(id, nome, salario));
            }

            ListaFuncionario(list_func);

            Console.WriteLine("");

            Console.Write("Informe o ID que irá receber o aumento de salario: ");
            int id_sal = int.Parse(Console.ReadLine());
            Console.Write("Informe o percentual do aumento: ");
            double perc = int.Parse(Console.ReadLine());

            Funcionario ex = list_func.Find(x => x.Id == id_sal);

            if (ex != null)
            {
                foreach (Funcionario lista in list_func)
                {
                    if (lista.Id == id_sal)
                    {
                        lista.AumentoSalario(perc);
                    }
                }
            } else
            {
                Console.WriteLine("Id não existente!");
            }           

            ListaFuncionario(list_func);

        }
        
        static void ListaFuncionario(List<Funcionario> lista_fun)
        {
            foreach (Funcionario lista in lista_fun)
            {
                Console.WriteLine("ID: " + lista.Id + " - Nome: " + lista.Nome + " - Salario: " + lista.Salario.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
