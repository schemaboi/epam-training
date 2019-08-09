using System;

namespace Epam.HomeWork.ClassTask
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            try
            {
                RectangleClassShowcase();
                StaticRectangleClassShowcase();

                ConsolePause();

                CircleClassShowcase();
                StaticCircleClassShowcase();

                ConsolePause();

                ComplexClassShowcase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ConsolePause();
        }

        private static void ConsolePause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void WriteHeaderMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        #region RECTANGLE

        private static void RectangleClassShowcase()
        {
            WriteHeaderMessage(">> Start Rectangle Class Showcase \n");

            ReadPoints(out Point leftUpper, out Point rightLower);

            var rectangle = new Rectangle(leftUpper, rightLower);

            Console.WriteLine(
                $"\nArea: { rectangle.CalculateArea() }, " +
                $"Perimeter: {rectangle.CalculatePerimeter()};\n" +
                $"Height: {rectangle.Height}, " +
                $"Width: {rectangle.Width}");

            WriteHeaderMessage("\n>> End Rectangle Class Showcase \n");
        }

        private static void StaticRectangleClassShowcase()
        {
            WriteHeaderMessage(">> Start StaticRectangle Class Showcase \n");

            ReadPoints(out Point leftUpper, out Point rightLower);

            Console.WriteLine(
                $"\nArea: { StaticRectangle.CalculateArea(leftUpper, rightLower) }, " +
                $"Perimeter: {StaticRectangle.CalculatePerimeter(leftUpper, rightLower)};\n" +
                $"Height: {StaticRectangle.CalculateHeight(leftUpper, rightLower)}, " +
                $"Width: {StaticRectangle.CalculateWidth(leftUpper, rightLower)}");

            WriteHeaderMessage("\n>> End StaticRectangle Class Showcase \n");
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
            WriteHeaderMessage(">> Start Circle Class Showcase \n");

            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            var circle = new Circle(radius); 

            Console.WriteLine($"Circle radius: {circle.Radius}, " +
                $"Area: {circle.Area}, " +
                $"Length: {circle.Length}.");

            WriteHeaderMessage("\n>> End Circle Class Showcase \n");
        }

        private static void StaticCircleClassShowcase()
        {
            WriteHeaderMessage(">> Start StaticCircle Class Showcase \n");

            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Circle radius: {radius}, " +
                $"Area: {StaticCircle.CalculateArea(radius)}, " +
                $"Length: {StaticCircle.CalculateLength(radius)}.");

            WriteHeaderMessage("\n>> End StaticCircle Class Showcase \n");
        }

        #endregion

        #region COMPLEX NUMBER

        private static void ComplexClassShowcase()
        {
            WriteHeaderMessage(">> Start ComplexNumber Class Showcase \n");

            Console.WriteLine("\nEnter first complex number: ");
            ReadComplexNumber(out ComplexNumber left);

            Console.WriteLine("\nEnter second complex number: ");
            ReadComplexNumber(out ComplexNumber right);

            Console.WriteLine($"Sum: {left + right}");
            Console.WriteLine($"Diffrence: {left - right}");
            Console.WriteLine($"Product: {left * right}");
            Console.WriteLine($"Quotient: {left / right}\n");

            WriteHeaderMessage("\n>> End ComplexNumber Class Showcase \n");
        }

        private static void ReadComplexNumber(out ComplexNumber number)
        {
            number = new ComplexNumber();

            Console.Write("Enter real part: ");
            string input = Console.ReadLine();
            number.Real = Convert.ToDouble(input);

            Console.Write("Enter imaginary part: ");
            input = Console.ReadLine();
            number.Imaginary = Convert.ToDouble(input);
        }

        #endregion
    }
}
