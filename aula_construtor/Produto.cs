using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace aula_construtor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        //Construtor
        public Produto(string nome, double preco, int qtde)
        {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Qtde;
        }

        public void AdicionarProduto(int qtde)
        {
            Qtde = Qtde + qtde;
        }

        public void RemoverProduto(int qtde)
        {
            Qtde = Qtde - qtde;
        }

        public override string ToString() //Sobreposição da Classe
        {
            return Nome + ", $ "
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", "
                        + Qtde + " unidades, Total: $ "
                        + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
