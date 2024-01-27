using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalculator.Models
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius) : base("коло")
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + $"; radius: {_radius}; area: {CalcArea():F2}";
        }

        public override double CalcArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
