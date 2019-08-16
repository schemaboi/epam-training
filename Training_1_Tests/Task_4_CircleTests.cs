using System;
using Xunit;

namespace Epam.HomeWork.Training1.Tests
{
    public class Task_4_CircleTest
    {
        private const int PRECISION = 15;

        [Fact]
        public void CalculatesArea()
        {
            const double radius = 3;
            const double expectedArea = Task4.Circle.PI * radius * radius;

            double actualArea = Task4.Circle.CalculateArea(radius);

            Assert.Equal(expectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesLength()
        {
            const double radius = 3;
            const double expectedLength = 2 * Task4.Circle.PI * radius;

            double actualLength = Task4.Circle.CalculateLength(radius);

            Assert.Equal(expectedLength, actualLength, PRECISION);
        }
    }
}
