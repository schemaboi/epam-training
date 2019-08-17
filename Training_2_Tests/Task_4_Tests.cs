namespace Epam.HomeWork.Training_2.Tests 
{
    using NUnit.Framework;
    using Task_4;

    public class Task_4_Tests   
    {
        [Test]
        public void FigureShouldDraw()
        {
            IDrawable figure = new Figure(0, 0);

            Assert.AreEqual("Figure: [0;0]", figure.Draw());
        }

        [Test]
        public void RectangleShouldDraw()
        {
            IDrawable rect = new Rectangle(0, 0);

            Assert.AreEqual("Rectangle: [0;0]", rect.Draw());
        }

        [Test]
        public void SquareShouldDraw()
        {
            IDrawable square = new Square(0, 0);

            Assert.AreEqual("Square: [0;0]", square.Draw());
        }
    }
}