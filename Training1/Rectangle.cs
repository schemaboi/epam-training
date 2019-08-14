using System;

namespace Epam.HomeWork.Training1
{
    public class Rectangle
    {
        #region Fields

        private const string CONSTRUCTION_ERROR_MESSAGE = "Invalid points for constructing a rectangle!";
        private Point _leftUpper;
        private Point _rightLower;

        #endregion


        #region Constructors

        public Rectangle(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(CONSTRUCTION_ERROR_MESSAGE);
            }
            _leftUpper = leftUpper;
            _rightLower = rightLower;
        }

        public Rectangle(double leftUpperX, double leftUpperY,
                         double rightLowerX, double rightLowerY)
            : this(new Point(leftUpperX, leftUpperY), new Point(rightLowerX, rightLowerY)) { }


        #endregion


        #region Properties

        public Point LeftUpper
        {
            get => _leftUpper;
            set
            {
                if (!IsPossibleRectangle(value, _rightLower))
                {
                    throw new ArgumentException(CONSTRUCTION_ERROR_MESSAGE);
                }
                _leftUpper = value;
            }
        }

        public Point RightLower
        {
            get => _rightLower;
            set
            {
                if (!IsPossibleRectangle(_leftUpper, value))
                {
                    throw new ArgumentException(CONSTRUCTION_ERROR_MESSAGE);
                }
                _rightLower = value;
            }
        }

        public double Height
        {
            get => _leftUpper.Y - _rightLower.Y;
        }

        public double Width
        {
            get => _rightLower.X - _leftUpper.X;
        }

        #endregion


        #region Methods

        public double CalculateArea()
        {
            return Height * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        private static bool IsPossibleRectangle(Point leftUpper, Point rightLower)
        {
            return leftUpper.X < rightLower.X
                && leftUpper.Y > rightLower.Y;
        }
        #endregion
    }
}
