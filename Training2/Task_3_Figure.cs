using System;

namespace Epam.HomeWork.Training2.Task3
{
    public class Figure
    {
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public virtual void Draw()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
