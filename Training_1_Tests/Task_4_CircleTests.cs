namespace Epam.HomeWork.Training1.Tests
{
    using Xunit;

    public class Task_4_CircleTest
    {
        private const int PRECISION = 15;

        [Fact]
        public void CalculatesArea()
        {
            const double Radius = 3;
            const double ExpectedArea = Task4.Circle.PI * Radius * Radius;

            double actualArea = Task4.Circle.CalculateArea(Radius);

            Assert.Equal(ExpectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesLength()
        {
            const double Radius = 3;
            const double ExpectedLength = 2 * Task4.Circle.PI * Radius;

            double actualLength = Task4.Circle.CalculateLength(Radius);

            Assert.Equal(ExpectedLength, actualLength, PRECISION);
        }
    }
}
