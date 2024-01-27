using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalculator.Models
{
    public abstract class Shape
    {
        protected string _name;
        public Shape(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"\n Фігура - {_name} ";
        }
        public abstract double CalcArea();
                
    }
}
