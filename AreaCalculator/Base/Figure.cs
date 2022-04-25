using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Base
{
    // Вычисление площади фигуры без знания типа фигуры
    // Не совсем понятно, создать фигуру наподобие многоугольника или уровень абстракции,
    // чтоб легче было добавлять фигуры?
    public abstract class Figure
    {
        private readonly Lazy<double> _area;

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        /// <summary>
        /// Property to get Figure's area
        /// </summary>
        public double Area => _area.Value;

        /// <summary>
        /// Method to calculate Figure's area
        /// </summary>
        /// <returns>Figure's area</returns>
        protected abstract double CalculateArea();

        /// <summary>
        /// Method to validate anything
        /// </summary>
        /// <returns>True - if validation succeed. False - if not</returns>
        protected abstract bool Validate();
    }
}
