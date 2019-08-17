namespace Epam.HomeWork.Training_2.Task_3
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

        public virtual string Draw()
        {
            return $"{GetType().Name}: [{X};{Y}]";
        }
    }
}
