namespace Epam.HomeWork
{
    using System;
    using Training_1;

    public class FirstTrainingTaskRunner : TaskRunner
    {
        public override void Run()
        {
            WriteHeaderMessage("Training 1");
            Console.WriteLine();

            RunTask1();
            Console.WriteLine();

            RunTask3();
            Console.WriteLine();

            RunTask4();
            Console.WriteLine();

            RunTask5();
            Console.WriteLine();
        }

        #region RunTask methods

        public void RunTask1()
        {
            WriteHeaderMessage(">> Task 1 and 2: Rectangle\n");
            Rectangle rectangle = new Rectangle();

            try
            {
                ReadPoints(out Point leftUpper, out Point rightLower);
                rectangle.LeftUpper = leftUpper;
                rectangle.RightLower = rightLower;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("RunTask() error!");
                return;
            }

            Console.WriteLine(
               $"\nArea: { rectangle.CalculateArea() }, " +
               $"Perimeter: {rectangle.CalculatePerimeter()};\n" +
               $"Height: {rectangle.Height}, " +
               $"Width: {rectangle.Width}");                         
        }

        public void RunTask3()
        {
            WriteHeaderMessage(">> Task 3: Circle\n");
            
            Console.Write("Enter radius: ");
            double radius = default;
            Circle circle = new Circle();

            try
            {
                radius = double.Parse(Console.ReadLine());
                circle.Radius = radius;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("RunTask() error!");
                return;
            }
            

            Console.WriteLine($"Circle radius: {circle.Radius}, " +
                $"Area: {circle.Area}, " +
                $"Length: {circle.Length}.");
        }

        public void RunTask4()
        {
            WriteHeaderMessage(">> Task 4: Static class Circle\n");

            Console.Write("Enter radius: ");
            if(!double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine("RunTask() error!");
                return;
            }

            Console.WriteLine($"Circle radius: {radius}, " +
                $"Area: {Training_1.Task_4.Circle.CalculateArea(radius)}, " +
                $"Length: {Training_1.Task_4.Circle.CalculateLength(radius)}.");
        }

        public void RunTask5()
        {
            WriteHeaderMessage(">> Task 5: ComplexNumber\n");

            try
            {
                Console.WriteLine("\nEnter first complex number: ");
                ReadComplexNumber(out ComplexNumber left);

                Console.WriteLine("\nEnter second complex number: ");
                ReadComplexNumber(out ComplexNumber right);

                Console.WriteLine($"Sum: {left + right}");
                Console.WriteLine($"Diffrence: {left - right}");
                Console.WriteLine($"Product: {left * right}");
                Console.WriteLine($"Quotient: {left / right}\n");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("RunTask() error!");
            }
           
        }

        #endregion

        #region Helper methods

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

        private static void ReadComplexNumber(out ComplexNumber number)
        {
            Console.Write("Enter real part: ");
            string input = Console.ReadLine();
            double real = Convert.ToDouble(input);

            Console.Write("Enter imaginary part: ");
            input = Console.ReadLine();
            double imaginary = Convert.ToDouble(input);

            number = new ComplexNumber(real, imaginary);
        }

        #endregion
    }
}
