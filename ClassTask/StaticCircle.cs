using System;

namespace Epam.HomeWork.ClassTask
{
    public static class StaticCircle
    {
        public const double PI = 3.14159265359;

        public static double CalculateArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Negative radius!");

            return PI * radius * radius;
        }

        public static double CalculateLength(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Negative radius!");

            return 2 * PI * radius;
        }
    }
}
