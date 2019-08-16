namespace Epam.HomeWork.Training1
{
    using System;

    public struct ComplexNumber : IEquatable<ComplexNumber>
    {
        public ComplexNumber(double real = 0.0, double imaginary = 0.0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        #region Interfaces

        public bool Equals(ComplexNumber other)
        {
            return Real == other.Real && Imaginary == other.Imaginary;
        }

        #endregion

        #region Properties

        public double Real { get; }

        public double Imaginary { get; }

        #endregion

        #region Operators

        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left.Real + right.Real, left.Imaginary + right.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left.Real - right.Real, left.Imaginary - right.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber value)
        {
            return new ComplexNumber(-value.Real, -value.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(
                left.Real * right.Real - left.Imaginary * right.Imaginary,
                left.Real * right.Imaginary + left.Imaginary * right.Real);
        }

        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            return left * right.Invert();
        }

        public static bool operator ==(ComplexNumber left, ComplexNumber right)
            => left.Equals(right);

        public static bool operator !=(ComplexNumber left, ComplexNumber right)
            => !left.Equals(right);

        public static implicit operator ComplexNumber(byte value)
            => new ComplexNumber(value);

        public static implicit operator ComplexNumber(short value)
            => new ComplexNumber(value);

        public static implicit operator ComplexNumber(int value)
            => new ComplexNumber(value);

        public static implicit operator ComplexNumber(long value)
            => new ComplexNumber(value);

        public static implicit operator ComplexNumber(float value)
            => new ComplexNumber(value);

        public static implicit operator ComplexNumber(double value)
            => new ComplexNumber(value);

        #endregion

        #region Methods

        public ComplexNumber Invert()
        {
            double denominator = Real * Real + Imaginary * Imaginary;
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero in ComplexNumber.Invert()");
            }

            return new ComplexNumber(Real / denominator, -Imaginary / denominator);
        }

        public override bool Equals(object obj)
        {
            return obj is ComplexNumber complexNumber && Equals(complexNumber);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return Imaginary >= 0 ? $"{Real}+{Imaginary}i" : $"{Real}{Imaginary}i";
        }

        #endregion
    }
}
