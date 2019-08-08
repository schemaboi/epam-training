using System;

namespace Epam.HomeWork.ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RectangleClassShowcase();
                StaticRectangleClassShowcase();

                CircleClassShowcase();
                StaticCircleClassShowcase();

                ComplexClassShowcase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        #region RECTANGLE

        private static void RectangleClassShowcase()
        {
            Console.WriteLine("\t>> Start Rectangle Class Showcase \n");

            ReadPoints(out Point leftUpper, out Point rightLower);

            var rectangle = new Rectangle(leftUpper, rightLower);

            Console.WriteLine(
                $"\nArea: { rectangle.CalculateArea() }, " +
                $"Perimeter: {rectangle.CalculatePerimeter()};\n" +
                $"Height: {rectangle.Height}, " +
                $"Width: {rectangle.Width}");

            Console.WriteLine("\n\t>> End Rectangle Class Showcase \n");
        }

        private static void StaticRectangleClassShowcase()
        {
            Console.WriteLine("\t>> Start StaticRectangle Class Showcase \n");

            ReadPoints(out Point leftUpper, out Point rightLower);

            Console.WriteLine(
                $"\nArea: { StaticRectangle.CalculateArea(leftUpper, rightLower) }, " +
                $"Perimeter: {StaticRectangle.CalculatePerimeter(leftUpper, rightLower)};\n" +
                $"Height: {StaticRectangle.CalculateHeight(leftUpper, rightLower)}, " +
                $"Width: {StaticRectangle.CalculateWidth(leftUpper, rightLower)}");

            Console.WriteLine("\n\t>> End StaticRectangle Class Showcase \n");
        }

        private static void ReadPoints(out Point leftUpper, out Point rightLower)
        {
            leftUpper = new Point();
            rightLower = new Point();

            Console.Write("Enter left upper x: ");
            leftUpper.X = double.Parse(Console.ReadLine());

            Console.Write("Enter left upper y: ");
            leftUpper.Y = double.Parse(Console.ReadLine());

            Console.Write("Enter right lower x: ");
            rightLower.X = double.Parse(Console.ReadLine());

            Console.Write("Enter right lower y: ");
            rightLower.Y = double.Parse(Console.ReadLine());
        }

#endregion

        #region CIRCLE

        private static void CircleClassShowcase()
        {
            Console.WriteLine("\t>> Start Circle Class Showcase \n");

            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            var circle = new Circle(radius); 

            Console.WriteLine($"Circle radius: {circle.Radius}, " +
                $"Area: {circle.Area}, " +
                $"Length: {circle.Length}.");

            Console.WriteLine("\n\t>> End Circle Class Showcase \n");
        }

        private static void StaticCircleClassShowcase()
        {
            Console.WriteLine("\t>> Start StaticCircle Class Showcase \n");

            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Circle radius: {radius}, " +
                $"Area: {StaticCircle.CalculateArea(radius)}, " +
                $"Length: {StaticCircle.CalculateLength(radius)}.");

            Console.WriteLine("\n\t>> End StaticCircle Class Showcase \n");
        }

        #endregion

        #region COMPLEX NUMBER

        private static void ComplexClassShowcase()
        {
            Console.WriteLine("\t>> Start ComplexNumber Class Showcase \n");

            Console.WriteLine("\nEnter first complex number: ");
            ReadComplexNumber(out ComplexNumber left);

            Console.WriteLine("\nEnter second complex number: ");
            ReadComplexNumber(out ComplexNumber right);


            Console.WriteLine($"Sum: {left + right}");
            Console.WriteLine($"Diffrence: {left - right}");
            Console.WriteLine($"Product: {left * right}");
            Console.WriteLine($"Quotient: {left / right}");

            Console.WriteLine("\n\t>> End ComplexNumber Class Showcase \n");
        }

        private static void ReadComplexNumber(out ComplexNumber number)
        {
            number = new ComplexNumber();

            Console.Write("Enter real part: ");
            number.Real = double.Parse(Console.ReadLine());

            Console.Write("Enter imaginary part: ");
            number.Imaginary = double.Parse(Console.ReadLine());
        }

        #endregion
    }
}
