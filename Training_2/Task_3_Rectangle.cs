using System;

namespace Epam.HomeWork.Training_2.Task_3
{
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public override string Draw()
        {
            var name = GetType().Name;
            Console.WriteLine(name);
            return name;
        }
    }
}