
namespace Epam.HomeWork.Training_2.Task_1_2
{
    public abstract class Figure 
    {
        protected Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public abstract string Draw();
    }
}
