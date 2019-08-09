using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.HomeWork.ClassTask
{
    public static class StaticRectangle
    {
        public const string BAD_ARGUMENTS_ERROR = "Invalid points for a rectangle!";
        public static double CalculateArea(Point leftUpper, Point rightLower)
        {
            if(!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BAD_ARGUMENTS_ERROR);
            }
            return CalculateHeight(leftUpper, rightLower) 
                * CalculateWidth(leftUpper, rightLower);
        }

        public static double CalculatePerimeter(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BAD_ARGUMENTS_ERROR);
            }
            return 2 * (CalculateHeight(leftUpper, rightLower)
                + CalculateWidth(leftUpper, rightLower));
        }

        public static double CalculateHeight(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BAD_ARGUMENTS_ERROR);
            }
            return leftUpper.Y - rightLower.Y;
        }
            

        public static double CalculateWidth(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException(BAD_ARGUMENTS_ERROR);
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
