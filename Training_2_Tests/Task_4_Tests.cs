using NUnit.Framework;


namespace Epam.HomeWork.Training_2.Tests 
{
    using Task_4;
    public class Task_4_Tests   
    {
        [Test]
        public void FigureShouldDraw()
        {
            IDrawable figure = new Figure(0, 0);

            Assert.AreEqual("Figure", figure.Draw());
        }

        [Test]
        public void RectangleShouldDraw()
        {
            IDrawable rect = new Rectangle(0, 0);

            Assert.AreEqual("Rectangle", rect.Draw());
        }

        [Test]
        public void SquareShouldDraw()
        {
            IDrawable square = new Square(0, 0);

            Assert.AreEqual("Square", square.Draw());
        }
    }
}