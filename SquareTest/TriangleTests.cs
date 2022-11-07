using Square;
using System;

namespace SquareTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void ZeroSideTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 4, 0));
        }

        [TestMethod]
        public void NegativeSideTest()
        {
            Assert.ThrowsException<ArgumentException>(()=>new Triangle(3, 4, -5));
        }

        [TestMethod]
        public void SumSidesTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 4, 8));
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool expected = true;

            Assert.AreEqual(expected, triangle.RightTriangle());
        }

        [TestMethod]
        public void GetSquareTest()
        {

            double a = 3;
            double b = 4;   
            double c = 5;
            var p = (a + b + c) / 2;
            Triangle triangle = new Triangle(a, b, c);
            double expectedSquare = Math.Sqrt(p* (p - a) * (p - b) * (p - c));
            double s = triangle.GetSquare();

            Assert.AreEqual(expectedSquare, triangle.GetSquare());
        }
    }
}