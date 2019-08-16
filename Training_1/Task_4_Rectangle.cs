namespace Epam.HomeWork.Training1.Task4
{
    using System;

    public static class Rectangle
    {
        public const string BadArgumentsErrorStr = "Invalid points for a rectangle!";

        public static double CalculateArea(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BadArgumentsErrorStr);
            }

            return CalculateHeight(leftUpper, rightLower)
                * CalculateWidth(leftUpper, rightLower);
        }

        public static double CalculatePerimeter(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BadArgumentsErrorStr);
            }

            return 2 * (CalculateHeight(leftUpper, rightLower)
                + CalculateWidth(leftUpper, rightLower));
        }

        public static double CalculateHeight(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BadArgumentsErrorStr);
            }

            return leftUpper.Y - rightLower.Y;
        }

        public static double CalculateWidth(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BadArgumentsErrorStr);
            }

            return rightLower.X - leftUpper.X;
        }

        private static bool IsPossibleRectangle(Point leftUpper, Point rightLower)
        {
            return leftUpper.X < rightLower.X
                && leftUpper.Y > rightLower.Y;
        }
    }
}
