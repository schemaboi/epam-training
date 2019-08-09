using System;

namespace Epam.HomeWork.ClassTask
{
    public class ComplexNumber : ICloneable
    {
        public ComplexNumber(double real = 0.0, double imaginary = 0.0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        #region Interfaces

        public object Clone()
        {
            return MemberwiseClone() as ComplexNumber;
        }

        #endregion

        #region Properties

        public double Real { get; set; }
        public double Imaginary { get; set; }

        #endregion

        #region Operators

        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = left.Real + right.Real,
                Imaginary = left.Imaginary + right.Imaginary
            };
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = left.Real - right.Real,
                Imaginary = left.Imaginary - right.Imaginary
            };
        }

        public static ComplexNumber operator -(ComplexNumber value)
        {
            return new ComplexNumber
            {
                Real = -value.Real,
                Imaginary = -value.Imaginary
            };
        }

        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = left.Real * right.Real - left.Imaginary * right.Imaginary,
                Imaginary = left.Real * right.Imaginary + left.Imaginary * right.Real
            };
        }

        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            return left * right.Invert();
        }

        public static bool operator ==(ComplexNumber left, ComplexNumber right) 
            => left.Equals(right);

        public static bool operator !=(ComplexNumber left, ComplexNumber right)
            => !left.Equals(right);

        #endregion

        #region Methods

        public ComplexNumber Invert()
        {
            var inverted = Clone() as ComplexNumber;
            double denominator = Real * Real + Imaginary * Imaginary;

            inverted.Real /= denominator;
            inverted.Imaginary /= -(denominator);

            return inverted;
        }

        public override bool Equals(object obj)
        {
            return obj?.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            string numberAsString = "";
            if(Imaginary >= 0)
            {
                numberAsString = $"{Real}+{Imaginary}i";
            }
            else
            {
                numberAsString = $"{Real}{Imaginary}i";
            }
            return numberAsString;
        }

        #endregion
    }
}
