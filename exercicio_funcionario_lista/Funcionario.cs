using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_funcionario_lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void AumentoSalario(double perc)
        {
            Salario = Salario + (Salario * perc / 100.0);
        }           
    }
}
