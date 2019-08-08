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

                //CircleClassShowcase();
                //StaticCircleClassShowcase();

                //ComplexClassShowcase();
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
            Console.WriteLine(" >> Start Rectangle Class Showcase \n");

            ReadPoints(out Point leftUpper, out Point rightLower);

            var rectangle = new Rectangle(leftUpper, rightLower);

            Console.WriteLine(
                $"Area: { rectangle.CalculateArea() }, " +
                $"Perimeter: {rectangle.CalculatePerimeter()};\n" +
                $"Height: {rectangle.Height}, " +
                $"Width: {rectangle.Width}");

            Console.WriteLine("\n >> End Rectangle Class Showcase \n");
        }

        private static void StaticRectangleClassShowcase()
        {
            Console.WriteLine(" >> Start StaticRectangle Class Showcase \n");

            ReadPoints(out Point leftUpper, out Point rightLower);

            Console.WriteLine(
                $"Area: { StaticRectangle.CalculateArea(leftUpper, rightLower) }, " +
                $"Perimeter: {StaticRectangle.CalculatePerimeter(leftUpper, rightLower)};\n" +
                $"Height: {StaticRectangle.CalculateHeight(leftUpper, rightLower)}, " +
                $"Width: {StaticRectangle.CalculateWidth(leftUpper, rightLower)}");

            Console.WriteLine("\n >> End StaticRectangle Class Showcase \n");
        }

        private static void ReadPoints(out Point leftUpper, out Point rightLower)
        {
            leftUpper = new Point();
            rightLower = new Point();

            Console.WriteLine("Enter left upper x: ");
            leftUpper.X = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter left upper y: ");
            leftUpper.Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter right lower x: ");
            rightLower.X = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter right lower y: ");
            rightLower.Y = double.Parse(Console.ReadLine());
        }

#endregion

        #region CIRCLE

        private static void CircleClassShowcase()
        {
            throw new NotImplementedException();
        }

        private static void StaticCircleClassShowcase()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region COMPLEX NUMBER

        private static void ComplexClassShowcase()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
