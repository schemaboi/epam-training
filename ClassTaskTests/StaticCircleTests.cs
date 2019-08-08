using System;
using Xunit;

namespace Epam.HomeWork.ClassTask.Tests
{
    public class StaticCircleTests
    {
        private const int PRECISION = 5;

        [Fact]
        public void CalculatesArea()
        {
            const double radius = 3;
            const double expectedArea = StaticCircle.PI * radius * radius;

            double actualArea = StaticCircle.CalculateArea(radius);

            Assert.Equal(expectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesLength()
        {
            const double radius = 3;
            const double expectedLength = 2 * StaticCircle.PI * radius;

            double actualLength = StaticCircle.CalculateLength(radius);

            Assert.Equal(expectedLength, actualLength, PRECISION);
        }
    }
}
