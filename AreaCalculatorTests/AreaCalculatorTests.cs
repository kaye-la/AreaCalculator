using Xunit;
using System;
using AreaCalculator.Figures;

namespace AreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CircleNegativeRadiusCheck()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Fact]
        public void CircleZeroRadiusCheck()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Fact]
        public void CircleAreaCalculate()
        {
            var expected = 314.1592653589793;
            var circle = new Circle(10);

            var actual = circle.Area;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleNegativeRadiusCheck()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -2, -3));
        }

        [Fact]
        public void TriangleZeroRadiusCheck()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 2, 1));
        }

        [Fact]
        public void TriangleAreaCalculate()
        {
            var expected = 36;
            var triangle = new Triangle(10, 9, 17);

            var actual = triangle.Area;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleIsRightFalse()
        {
            var expected = false;
            var triangle = new Triangle(10, 9, 17);

            var actual = triangle.IsRightTriangle;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleIsRightTrue()
        {
            var expected = true;
            var triangle = new Triangle(3, 4, 5);

            var actual = triangle.IsRightTriangle;

            Assert.Equal(expected, actual);
        }
    }
}
