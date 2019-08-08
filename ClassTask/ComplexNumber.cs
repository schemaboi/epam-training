using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.HomeWork.ClassTask
{
    public class ComplexNumber : ICloneable, IComparable<ComplexNumber>
    {
        public ComplexNumber(double real = 0.0, double imaginary = 0.0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        #region Interfaces

        public object Clone()
        {
            return new ComplexNumber(Real, Imaginary);
        }

        public int CompareTo(ComplexNumber other)
        {
            if (Real == other.Real)
            {
                return Imaginary.CompareTo(other.Imaginary);
            }
            return Real.CompareTo(other.Real);
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
            var inverted = (ComplexNumber)Clone();

            inverted.Real /= Real * Real + Imaginary * Imaginary;
            inverted.Imaginary /= Real * Real + Imaginary * Imaginary;

            return inverted;
        }

        public override bool Equals(object obj)
        {
            return !(obj is ComplexNumber value) ? false 
                : Real == value.Real && Imaginary == value.Imaginary;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"{Real}{Imaginary.ToString("+0;-#")}i";
        }

        #endregion
    }
}
