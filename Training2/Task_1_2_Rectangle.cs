using System;

namespace Epam.HomeWork.Training2.Task1_2
{
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
