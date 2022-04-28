using AreaCalculator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Figures
{
    public class Triangle : Figure
    {
        private readonly Lazy<bool> _isRightTriangle;
        private readonly double _firSide;
        private readonly double _secSide;
        private readonly double _thirdSide;

        public Triangle(double firSide, double secSide, double thirdSide)
        {
            _firSide = firSide;
            _secSide = secSide;
            _thirdSide = thirdSide;

            Validate();
            _isRightTriangle = new Lazy<bool>(CheckRightTriangle);
        }

        public bool IsRightTriangle => _isRightTriangle.Value;

        /// <summary>
        /// Calculate area with Heron's formula
        /// </summary>
        /// <returns>Area</returns>
        protected override sealed double CalculateArea()
        {
            var halfPerimeter = (_firSide + _secSide + _thirdSide) / 2;
            var tempSide = (halfPerimeter - _firSide) * (halfPerimeter - _secSide) * (halfPerimeter - _thirdSide);

            return Math.Sqrt(halfPerimeter * tempSide);
        }

        /// <summary>
        /// Validate 
        /// </summary>
        /// <returns>True - if validation succeed. False - if not</returns>
        protected override sealed bool Validate()
        {
            if (_firSide < 0 || _secSide < 0 || _thirdSide < 0)
                throw new ArgumentOutOfRangeException("Argument can't be negative");
            else if (_firSide == 0 || _secSide == 0 || _thirdSide == 0)
                throw new ArgumentOutOfRangeException("Argument can't be null");
            else if (!(_firSide < _secSide + _thirdSide || _secSide < _firSide + _thirdSide || _thirdSide < _firSide + _secSide))
                throw new ArgumentException("Triangle does not exist");

            return true;

            // can be added more validations..
        }

        /// <summary>
        /// Check if triangle is right
        /// </summary>
        /// <returns>True - if right trianlge. False - if not</returns>
        public bool CheckRightTriangle()
        {
            var hypotenuse = new[] { _firSide, _secSide, _thirdSide }.Max();
            var temp = _firSide * _firSide + _secSide * _secSide + _thirdSide * _thirdSide - hypotenuse * hypotenuse;

            return hypotenuse * hypotenuse == temp;
        }
    }
}
