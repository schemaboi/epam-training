using System;

namespace Epam.HomeWork.Training2.Task4
{
    public class Square : Figure
    {
        public Square(double x, double y) : base(x, y)
        {
        } 

        public override void Draw()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
