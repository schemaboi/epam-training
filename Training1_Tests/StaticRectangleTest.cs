using System;
using Xunit;

namespace Epam.HomeWork.Training1.Tests
{
    public class StaticRectangleTest
    {
        private const int PRECISION = 15;

        [Fact] 
        public void CalculatesArea()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            const double expectedArea = 4;

            double actualArea = StaticRectangle.CalculateArea(leftUpper, rightLower);

            Assert.Equal(expectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesRectanglePerimeter()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            const double expectedPerimeter = 8; 

            double actualPerimeter = StaticRectangle.CalculatePerimeter(leftUpper, rightLower);

            Assert.Equal(expectedPerimeter, actualPerimeter, PRECISION);
        }

        [Fact]
        public void CalculatesHeightAndWidth()
        {
            var leftUpper = new Point(0, 3);
            var rightLower = new Point(2, 0);
            const double expectedHeight = 3;
            const double expectedWidth = 2;

            double actualHeight = StaticRectangle.CalculateHeight(leftUpper, rightLower);
            double actualWidth = StaticRectangle.CalculateWidth(leftUpper, rightLower);

            Assert.Equal(actualHeight, expectedHeight, PRECISION);
            Assert.Equal(actualWidth, expectedWidth, PRECISION);
        }

        [Fact]
        public void HandlesInvalidArguments() 
        {
            Action calculateHeightCode = PassesInvalidArgumentsToCalculateHeight;
            Action calculateWidthCode = PassesInvalidArgumentsToCalculateWidth;
            Action calculateAreaCode = PassesInvalidArgumentsToCalculateArea;
            Action calculatePerimetrCode = PassesInvalidArgumentsToCalculatePerimeter;
             
            Assert.Throws<ArgumentException>(calculateHeightCode);
            Assert.Throws<ArgumentException>(calculateWidthCode);
            Assert.Throws<ArgumentException>(calculateAreaCode);
            Assert.Throws<ArgumentException>(calculatePerimetrCode);
        }

        private void PassesInvalidArgumentsToCalculateHeight() 
        {
            var leftUpper = new Point(7, 3);
            var rightLower = new Point(0, 5);
            double actualHeight = StaticRectangle.CalculateHeight(leftUpper, rightLower);
        }

        private void PassesInvalidArgumentsToCalculateWidth()
        {
            var leftUpper = new Point(7, 3);
            var rightLower = new Point(0, 5);
            double actualWidth = StaticRectangle.CalculateWidth(leftUpper, rightLower);
        }

        private void PassesInvalidArgumentsToCalculateArea()
        {
            var leftUpper = new Point(7, 3); 
            var rightLower = new Point(0, 5);
            double actualArea = StaticRectangle.CalculateArea(leftUpper, rightLower);
        }
        private void PassesInvalidArgumentsToCalculatePerimeter()
        {
            var leftUpper = new Point(7, 3);
            var rightLower = new Point(0, 5);
            double actualPerimeter = StaticRectangle.CalculatePerimeter(leftUpper, rightLower);
        }
    }
}
