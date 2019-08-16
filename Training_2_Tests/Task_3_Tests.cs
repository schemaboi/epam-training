namespace Epam.HomeWork.Training_2.Tests 
{
    using NUnit.Framework;
    using Task_3; 

    public class Task_3_Tests  
    {     
        [Test]
        public void FigureShouldDraw()
        {
            Figure figure = new Figure(0, 0);

            Assert.AreEqual("Figure", figure.Draw());
        }

        [Test]
        public void RectangleShouldDraw()
        {
            Figure rect = new Rectangle(0, 0);

            Assert.AreEqual("Rectangle", rect.Draw());
        }

        [Test]
        public void SquareShouldDraw()
        {
            Figure square = new Square(0, 0);

            Assert.AreEqual("Square", square.Draw());
        }
    }
}