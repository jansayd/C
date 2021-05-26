using exercicio_abstract_herencas.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstract_herencas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
