using Square;
using System;

namespace SquareTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void ZeroRadiusTest()
        {

            Assert.ThrowsException<ArgumentException>(()=>new Circle(0));
        }

        [TestMethod]
        public void NegativeRadiusTest()
        {

            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }

        [TestMethod]
        public void GetSquareTest()
        {
            double radius = 10;
            Circle circle = new Circle(radius);
            double expectedSquare = Math.PI * radius * radius;

            Assert.AreEqual(expectedSquare, circle.GetSquare());
        }
    }
}