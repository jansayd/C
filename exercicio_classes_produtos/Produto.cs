using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercicio_classes_produtos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

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
