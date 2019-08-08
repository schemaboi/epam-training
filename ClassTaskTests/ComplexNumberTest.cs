using System;
using Xunit;

namespace Epam.HomeWork.ClassTask.Tests
{
    public class ComplexNumberTest
    {
        public const int PRECISION = 15;

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

            Assert.Equal(expectedSum.Real, actualSum.Real, PRECISION);
            Assert.Equal(expectedSum.Imaginary, actualSum.Imaginary, PRECISION);

            Assert.Equal(expectedDiffrence.Real, actualDiffrence.Real, PRECISION);
            Assert.Equal(expectedDiffrence.Imaginary, actualDiffrence.Imaginary, PRECISION);

            Assert.Equal(expectedProduct.Real, actualProduct.Real, PRECISION);
            Assert.Equal(expectedProduct.Imaginary, actualProduct.Imaginary, PRECISION);

            Assert.Equal(expectedQuotient.Real, actualQuotient.Real, PRECISION);
            Assert.Equal(expectedQuotient.Imaginary, actualQuotient.Imaginary, PRECISION);

            Assert.Equal(expectedNegated.Real, actualNegated.Real, PRECISION);
            Assert.Equal(expectedNegated.Imaginary, actualNegated.Imaginary, PRECISION);
        }

        [Fact]
        public void ComparesComplexNumbers()
        {
            var left = new ComplexNumber(9, 6);
            var right = new ComplexNumber(9, 6);
            var other = new ComplexNumber(8, 8);
             
            Assert.Equal(left, right);
            Assert.NotEqual(left, other);
            Assert.True(left == right);
            Assert.True(left != other);
            Assert.True(left.Equals(right));
        }

        [Fact]
        public void ConvertsToString()
        {
            var zeroComplex = new ComplexNumber();
            var negativeComplex = new ComplexNumber(-2, -2);
            var positiveComplex = new ComplexNumber(2, 2);

            var expectedZeroComplexNumberString = "0+0i";
            var expectedNegativeComplexNumberString = "-2-2i";
            var expectedPositiveComplexNumberString = "2+2i";

            Assert.Equal(expectedZeroComplexNumberString, zeroComplex.ToString());
            Assert.Equal(expectedNegativeComplexNumberString, negativeComplex.ToString());
            Assert.Equal(expectedPositiveComplexNumberString, positiveComplex.ToString());
        }
    }
}
