namespace Epam.HomeWork.Training_1.Tests
{
    using Xunit;

    public class Task_3_Tests
    {
        private const int PRECISION = 15;

        [Fact]
        public void CalculatesArea()
        {
            const double Radius = 3;
            var circle = new Circle
            {
                Radius = Radius
            };
            const double ExpectedArea = Circle.PI * Radius * Radius;

            double actualArea = circle.Area;

            Assert.Equal(ExpectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesLength()
        {
            const double Radius = 3;
            var circle = new Circle
            {
                Radius = Radius
            };
            const double ExpectedLength = 2 * Circle.PI * Radius;

            double actualLength = circle.Length;

            Assert.Equal(ExpectedLength, actualLength, PRECISION);
        }
    }
}
