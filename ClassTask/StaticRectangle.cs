using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.HomeWork.ClassTask
{
    public static class StaticRectangle
    {
        public static double CalculateArea(Point leftUpper, Point rightLower)
        {
            if(!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException("Invalid points for constructing a rectangle!");
            }
            return CalculateHeight(leftUpper, rightLower) 
                * CalculateWidth(leftUpper, rightLower);
        }

        public static double CalculatePerimeter(Point leftUpper, Point rightLower)
        {
            if (!IsPossibleRectangle(leftUpper, rightLower))
            {
                throw new ArgumentException("Invalid points for constructing a rectangle!");
            }
            return 2 * (CalculateHeight(leftUpper, rightLower)
                + CalculateWidth(leftUpper, rightLower));
        }

        public static double CalculateHeight(Point leftUpper, Point rightLower)
            => leftUpper.Y - rightLower.Y;

        public static double CalculateWidth(Point leftUpper, Point rightLower)
            => rightLower.X - leftUpper.X;

        private static bool IsPossibleRectangle(Point leftUpper, Point rightLower)
        {
            return leftUpper.X < rightLower.X
                && leftUpper.Y > rightLower.Y;
        }      
    }
}
