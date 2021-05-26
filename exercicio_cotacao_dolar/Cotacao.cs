using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_cotacao_dolar
{
    class Cotacao
    {
        public static double iof = 6.0;

        public static double ConversaoDolar(double CotacaoMoeda, double ValorCompra)
        {
            double ValorTotal = CotacaoMoeda * ValorCompra;
            return (double) ValorTotal + (ValorTotal * (iof / 100));
        }
    }
}
