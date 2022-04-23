using Xunit;
using System;
using AreaCalculator.Figures;

namespace AreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void Circle_NegativeRadius__ExceptionReturned()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Fact]
        public void Circle_ZeroRadius__ExceptionReturned()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Fact]
        public void CircleAreaCalculate_10__314Returned()
        {
            var expected = 314.1592653589793;
            var circle = new Circle(10);

            var actual = circle.Area;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_NegativeRadius__ExceptionReturned()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -2, -3));
        }

        [Fact]
        public void Triangle_ZeroRadius__ExceptionReturned()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 2, 1));
        }

        [Fact]
        public void TriangleAreaCalculate_10A9B17C__36Returned()
        {
            var expected = 36;
            var triangle = new Triangle(10, 9, 17);

            var actual = triangle.Area;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleIsRight_10A9B17C__falseReturned()
        {
            var expected = false;
            var triangle = new Triangle(10, 9, 17);

            var actual = triangle.IsRightTriangle;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleIsRight_3A4B5C__trueReturned()
        {
            var expected = true;
            var triangle = new Triangle(3, 4, 5);

            var actual = triangle.IsRightTriangle;

            Assert.Equal(expected, actual);
        }
    }
}
