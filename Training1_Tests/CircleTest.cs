using System;
using Xunit;


namespace Epam.HomeWork.Training1.Tests 
{
    public class CircleTest
    {
        private const int PRECISION = 15;

        [Fact]
        public void CalculatesArea()
        {
            const double radius = 3;
            var circle = new Circle
            {
                Radius = radius
            };
            const double expectedArea = Circle.PI * radius * radius;

            double actualArea = circle.Area;

            Assert.Equal(expectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesLength()
        {
            const double radius = 3;
            var circle = new Circle
            {
                Radius = radius
            };
            const double expectedLength = 2 * Circle.PI * radius;

            double actualLength = circle.Length;

            Assert.Equal(expectedLength, actualLength, PRECISION);
        }
    }
}
