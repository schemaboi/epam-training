using NUnit.Framework;

namespace Epam.HomeWork.Training_2.Tests 
{
    using Task_1_2;
    public class Task_1_2_Tests  
    {    
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