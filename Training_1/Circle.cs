using System;

namespace Epam.HomeWork.ClassTask
{
    public class Circle
    {
        public const double PI = 3.14159265359;
        private double _radius;

        public Circle(double radius = 0.0)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Negative radius!");

                _radius = value;
            }
        }

        public double Area { get => PI * Radius * Radius; }
        public double Length { get => 2 * PI * Radius; }

    }
}
