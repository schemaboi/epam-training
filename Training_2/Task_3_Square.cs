namespace Epam.HomeWork.Training_2.Task_3
{
    using System;

    public class Square : Figure
    {
        public Square(double x, double y) : base(x, y)
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