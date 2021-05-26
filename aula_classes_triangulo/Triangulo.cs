using System;
using System.Collections.Generic;
using System.Text;

namespace aula_classes_triangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Metodo da Classe Triangulo, para calcular a área de um triangulo
        public double CalculaAreaTriangulo()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
