using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercicio_classes_aluno
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double NFinal;
        
        public void CalculaNotaFinal()
        {
            NFinal = (double)N1 + (double)N2 + (double)N3;
        }

        public string VerificaSituacaoFinal()
        {
            if (NFinal < 60)
            {
                return "REPROVADO - faltaram " + (60 - NFinal).ToString("F2", CultureInfo.InvariantCulture) + " pontos";
            } else
            {
                return "APROVADO";
            }
        }
    }
}
