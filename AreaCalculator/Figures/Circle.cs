using AreaCalculator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Figures
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
            Validate();
        }

        protected override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        protected override bool Validate()
        {
            if (_radius < 0)
                throw new ArgumentException("Argument can't be negative");
            else if (_radius == 0)
                throw new ArgumentException("Argument can't be negative");
            return true;
        }
    }
}
