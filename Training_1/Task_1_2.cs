namespace Epam.HomeWork.Training1
{
    using System;

    public class Rectangle
    {
        #region Fields

        private const string InvalidArgumentsErrorDesciption = "Invalid points for constructing a rectangle!";
        private Point _leftUpper;
        private Point _rightLower;

        #endregion

        #region Constructors

        public Rectangle(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(InvalidArgumentsErrorDesciption);
            }

            _leftUpper = leftUpper;
            _rightLower = rightLower;
        }

        public Rectangle(
            double leftUpperX, 
            double leftUpperY,
            double rightLowerX, 
            double rightLowerY)
            : this(new Point(leftUpperX, leftUpperY), new Point(rightLowerX, rightLowerY))
        {
        }

        #endregion

        #region Properties

        public Point LeftUpper
        {
            get => _leftUpper;
            set
            {
                if (!IsPossibleRectangle(value, _rightLower))
                {
                    throw new ArgumentException(InvalidArgumentsErrorDesciption);
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
                    throw new ArgumentException(InvalidArgumentsErrorDesciption);
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

        public double Area
        {
            get => Height * Width;
        }

        public double Perimeter
        {
            get => 2 * (Height + Width);
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
