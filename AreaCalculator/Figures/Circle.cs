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

        /// <summary>
        /// Calculate circle's area
        /// </summary>
        /// <returns>Circle's area</returns>
        protected override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        /// <summary>
        /// Validate for negative & null
        /// </summary>
        /// <returns>True - if validation succeed. False - if not</returns>
        protected override bool Validate()
        {
            if (_radius < 0)
                throw new ArgumentOutOfRangeException("Argument can't be negative");
            else if (_radius == 0)
                throw new ArgumentOutOfRangeException("Argument can't be null");
            return true;
        }
    }
}
