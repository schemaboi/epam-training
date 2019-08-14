using System;
using Xunit;

namespace Epam.HomeWork.Training1.Tests
{ 
    public class ComplexNumberTest
    {
        [Fact]
        public void CalculatesSimpleAriphmetic()
        {
            var leftComplexNumber = new ComplexNumber(2, 2);
            var rightComplexNumber = new ComplexNumber(2, 3);

            var expectedSum = new ComplexNumber(4, 5);
            var expectedDiffrence = new ComplexNumber(0, -1);
            var expectedProduct = new ComplexNumber(-2, 10);
            var expectedQuotient = new ComplexNumber(10.0/13.0, -2.0/13.0);
            var expectedNegated = new ComplexNumber(-2, -2);

            var actualSum = leftComplexNumber + rightComplexNumber;
            var actualDiffrence = leftComplexNumber - rightComplexNumber;
            var actualProduct = leftComplexNumber * rightComplexNumber;
            var actualQuotient = leftComplexNumber / rightComplexNumber;
            var actualNegated = -leftComplexNumber;

            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedDiffrence, actualDiffrence);
            Assert.Equal(expectedProduct, actualProduct);
            Assert.Equal(expectedQuotient, actualQuotient);
            Assert.Equal(expectedNegated, actualNegated);
        }

        [Fact]
        public void HandlesDivisionByZero()
        {
            Action edgyCode = () => 
            {
                ComplexNumber leftComplexNumber = new ComplexNumber(2, 2);
                ComplexNumber rightComplexNumber = new ComplexNumber(0, 0);
                ComplexNumber result = leftComplexNumber / rightComplexNumber;
            };

            Assert.Throws<DivideByZeroException>(edgyCode);
        }

        [Fact]
        public void ComparesComplexNumbers()
        {
            var left = new ComplexNumber(9, 6);
            var right = new ComplexNumber(9, 6);
            var other = new ComplexNumber(8, 8);
             
            Assert.Equal(left, right);
            Assert.True(left.Equals(right as object));
            Assert.True(left.GetHashCode() == right.GetHashCode());
            Assert.True((-left).ToString() == (-right).ToString());
            Assert.NotEqual(left, other);
            Assert.True(left == right);
            Assert.True(left != other);
            Assert.True(left.Equals(right));
        }

        [Fact]
        public void ConvertsFromBaseTypes()
        {
            Assert.Equal((byte)1, new ComplexNumber(1));
            Assert.Equal((short)1, new ComplexNumber(1));
            Assert.Equal(1, new ComplexNumber(1));
            Assert.Equal(1L, new ComplexNumber(1));
            Assert.Equal(1.0f, new ComplexNumber(1));
            Assert.Equal(1.0d, new ComplexNumber(1));
        }
    }
}
