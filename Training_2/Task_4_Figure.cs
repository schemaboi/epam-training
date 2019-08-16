using System;

namespace Epam.HomeWork.Training_2.Task_4
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


        public virtual string Draw()
        {
            var name = GetType().Name;
            Console.WriteLine(name);
            return name;
        }
    }
}
