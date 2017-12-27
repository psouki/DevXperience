using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imutabilidade
{
    public sealed class Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        
        public Shape(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public Shape WithSideA(double newSideA) => new Shape(newSideA, SideB);
        public Shape WithSideB(double newSideB) => new Shape(SideA, newSideB);
    }
}
