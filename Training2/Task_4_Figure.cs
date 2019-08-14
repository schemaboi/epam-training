using System;

namespace Epam.HomeWork.Training2.Task4
{
    public class Figure : IDrawable
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
