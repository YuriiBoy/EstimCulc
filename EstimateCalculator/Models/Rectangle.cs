using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalculator.Models
{
    public class Rectangle : Shape
    {
        private double _sideA;
        private double _sideB;

        public Rectangle(double sideA, double sideB) : base("Прямокутник")
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public override string ToString()
        {
            return base.ToString() + $"; side A: {_sideA}; side B: {_sideB}; area: {CalcArea():F2}";
        }

        public override double CalcArea()
        {
            return _sideA * _sideB;
        }
    }
}
