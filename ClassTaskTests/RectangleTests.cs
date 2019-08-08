using System;
using Xunit;

namespace Epam.HomeWork.ClassTask.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void CalculatesArea() 
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower);
            const double expectedArea = 4;

            double actualArea = rectangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 5);
        }

        [Fact]
        public void CalculatesRectanglePerimeter()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower);
            const double expectedPerimeter = 8;

            double actualArea = rectangle.CalculatePerimeter();

            Assert.Equal(expectedPerimeter, actualArea, 5);
        }

        [Fact]
        public void CalculatesHeightAndWidth()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower);
            const double expectedHeight = 2;
            const double expectedWidth = 2;

            double actualHeight = rectangle.Height;
            double actualWidth = rectangle.Width;

            Assert.Equal(actualHeight, expectedHeight, 5);
            Assert.Equal(actualWidth, expectedWidth, 5);
        }

        [Fact]
        public void HandlesInvalidArguments()
        {
            Type execptionType = new ArgumentException().GetType();
            Action constructorCode = CreateInvalidRectangle;
            Action leftUpperSetter = SetInvalidLeftUpperPoint;
            Action rightLowerSetter = SetInvalidRightLower;

            Assert.Throws(execptionType, constructorCode);
            Assert.Throws(execptionType, leftUpperSetter);
            Assert.Throws(execptionType, rightLowerSetter);
        }

        private void CreateInvalidRectangle()
        {
            var leftUpper = new Point(2, 0);
            var rightLower = new Point(0, 2);
            var rectangle = new Rectangle(leftUpper, rightLower);
        }

        private void SetInvalidLeftUpperPoint()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower)
            {
                LeftUpper = new Point(-2, -2)
            };
        }

        private void SetInvalidRightLower()  
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower)
            {
                RightLower = new Point(-2, -2)
            };
        }
    } 
}
