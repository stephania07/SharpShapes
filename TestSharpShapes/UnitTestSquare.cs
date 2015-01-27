using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(50, 50);
            Assert.AreEqual(50, square.Width);
            Assert.AreEqual(50, square.Height);
        }
        [TestMethod]
        public void TestSidesCout()
        {
            Square square = new Square(1, 5);
            Assert.AreEqual(5, square.Area());      
        }

        
    }
}
