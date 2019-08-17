namespace Epam.HomeWork.Training_2.Task_3
{
    public class Square : Figure
    {
        public Square(double x, double y) : base(x, y)
        {
        } 

        public override string Draw()
        {
            return $"{GetType().Name}: [{X};{Y}]";
        }
    }
}