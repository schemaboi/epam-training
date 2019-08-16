using System;
using Xunit;

namespace Epam.HomeWork.Training1.Tests
{
    public class Task_1_2_Tests 
    { 
        private const int PRECISION = 15;

        [Fact]
        public void CalculatesArea() 
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower);
            const double expectedArea = 4;

            double actualArea = rectangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, PRECISION);
            Assert.Equal(expectedArea, rectangle.Area, PRECISION);
        }

        [Fact]
        public void CalculatesRectanglePerimeter()
        {
            var leftUpper = new Point(0, 2);
            var rightLower = new Point(2, 0);
            var rectangle = new Rectangle(leftUpper, rightLower);
            const double expectedPerimeter = 8;

            double actualPerimeter = rectangle.CalculatePerimeter();

            Assert.Equal(expectedPerimeter, actualPerimeter, PRECISION);
            Assert.Equal(expectedPerimeter, rectangle.Perimeter, PRECISION);
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

            Assert.Equal(actualHeight, expectedHeight, PRECISION);
            Assert.Equal(actualWidth, expectedWidth, PRECISION);
        }

        [Fact]
        public void HandlesInvalidArguments()
        {
            Action constructorCode = CreateInvalidRectangle;
            Action leftUpperSetter = SetInvalidLeftUpperPoint;
            Action rightLowerSetter = SetInvalidRightLower;

            Assert.Throws<ArgumentException>(constructorCode);
            Assert.Throws<ArgumentException>(leftUpperSetter);
            Assert.Throws<ArgumentException>(rightLowerSetter);
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
