namespace Epam.HomeWork.Training_2.Task_4
{
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public override string Draw()
        {
            return $"{GetType().Name}: [{X};{Y}]";
        }
    }
}
