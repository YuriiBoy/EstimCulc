using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalculator.Models
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public Triangle( double sideA, double sideB, double sideC) : base("Трикутник")
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override string ToString()
        {
            return base.ToString() + $"; side A: {_sideA}; side B: {_sideB}; side C: {_sideC}; area: {CalcArea():F2}";
        }

        public override double CalcArea()
        {
            double P = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(P * (P - _sideA) * (P - _sideB) * (P - _sideC));
        }
    }
}
