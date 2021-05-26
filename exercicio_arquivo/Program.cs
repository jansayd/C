using System;
using System.Globalization;
using System.IO;

namespace exercicio_arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o caminho/arquivo com itens de vendas: ");
                string path = Console.ReadLine();
                string diretorio = Path.GetDirectoryName(path);
                string path_destino = @"D:\C#\projetos\exercicio_arquivo\arquivos\out\summary.csv";
                
                //Lendo o arquivo de vendas
                using (StreamReader sr = File.OpenText(path))
                {
                    File.Delete(path_destino); //apagar o arquivo, caso exista

                    while (!sr.EndOfStream)
                    {
                        //Lendo itens do arquivo
                        string[] line = sr.ReadLine().Split(';');
                        string produto = line[0];
                        double preco = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int qtde = int.Parse(line[2]);
                        double total = preco * qtde;
                        //Gravando itens sumarizados no arquivo summary.csv
                        using (StreamWriter sw = File.AppendText(path_destino))
                        {
                            sw.WriteLine(produto + ";" + total.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }

                //Lendo o arquivo Sumarizado
                using (StreamReader sw_vendas = File.OpenText(path_destino))
                {
                    Console.WriteLine("----------------RESUMO VENDAS--------------");
                    while (!sw_vendas.EndOfStream)
                    {
                        string[] line = sw_vendas.ReadLine().Split(';');
                        Console.WriteLine(line[0] + " - " + line[1]);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro Econtrado: " + e.Message);
            }
        }
    }
}
