
namespace Epam.HomeWork.Training2.Task1_2
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

        public abstract void Draw();
    }
}
