namespace Epam.HomeWork.Training_1.Tests
{
    using System;
    using Xunit;

    public class Task_4_RectangleTests 
    { 
        private const int PRECISION = 15;

        [Fact] 
        public void CalculatesArea()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            const double ExpectedArea = 4;

            double actualArea = Task_4.Rectangle.CalculateArea(leftUpper, rightLower);

            Assert.Equal(ExpectedArea, actualArea, PRECISION);
        }

        [Fact]
        public void CalculatesRectanglePerimeter()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            const double ExpectedPerimeter = 8; 

            double actualPerimeter = Task_4.Rectangle.CalculatePerimeter(leftUpper, rightLower);

            Assert.Equal(ExpectedPerimeter, actualPerimeter, PRECISION);
        }

        [Fact]
        public void CalculatesHeightAndWidth()
        {
            var leftUpper = new Point(0, 3);
            var rightLower = new Point(2, 0);
            const double ExpectedHeight = 3;
            const double ExpectedWidth = 2;

            double actualHeight = Task_4.Rectangle.CalculateHeight(leftUpper, rightLower);
            double actualWidth = Task_4.Rectangle.CalculateWidth(leftUpper, rightLower);

            Assert.Equal(actualHeight, ExpectedHeight, PRECISION);
            Assert.Equal(actualWidth, ExpectedWidth, PRECISION);
        }

        [Fact]
        public void HandlesInvalidArguments() 
        {
            Action calculateHeightCode = this.PassesInvalidArgumentsToCalculateHeight;
            Action calculateWidthCode = this.PassesInvalidArgumentsToCalculateWidth;
            Action calculateAreaCode = this.PassesInvalidArgumentsToCalculateArea;
            Action calculatePerimetrCode = this.PassesInvalidArgumentsToCalculatePerimeter;
             
            Assert.Throws<ArgumentException>(calculateHeightCode);
            Assert.Throws<ArgumentException>(calculateWidthCode);
            Assert.Throws<ArgumentException>(calculateAreaCode);
            Assert.Throws<ArgumentException>(calculatePerimetrCode);
        }

        private void PassesInvalidArgumentsToCalculateHeight() 
        {
            var leftUpper = new Point(7, 3);
            var rightLower = new Point(0, 5);
            double actualHeight = Task_4.Rectangle.CalculateHeight(leftUpper, rightLower);
        }

        private void PassesInvalidArgumentsToCalculateWidth()
        {
            var leftUpper = new Point(7, 3);
            var rightLower = new Point(0, 5);
            double actualWidth = Task_4.Rectangle.CalculateWidth(leftUpper, rightLower);
        }

        private void PassesInvalidArgumentsToCalculateArea()
        {
            var leftUpper = new Point(7, 3); 
            var rightLower = new Point(0, 5);
            double actualArea = Task_4.Rectangle.CalculateArea(leftUpper, rightLower);
        }

        private void PassesInvalidArgumentsToCalculatePerimeter()
        {
            var leftUpper = new Point(7, 3);
            var rightLower = new Point(0, 5);
            double actualPerimeter = Task_4.Rectangle.CalculatePerimeter(leftUpper, rightLower);
        }
    }
}
