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
        public void TestSidesCount()
        {
            Square square = new Square(3, 3);
            Assert.AreEqual(4, square.SidesCount);      
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSaintyChecksWidth()
        {
            Square square = new Square(5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSaintyChecksWidthPositivity()
        {
            Square square = new Square(5, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSaintyChecksHeight()
        {
            Square square = new Square(5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSaintyChecksHeightPositivity()
        {
            Square square = new Square(-5, 5);
        }

        [TestMethod]
        public void TestScaleSquare200Percent()
        {
            Square square = new Square(10, 10);
            square.Scale(200);
            Assert.AreEqual(20, square.Width);
            Assert.AreEqual(20, square.Height);           
        }

        [TestMethod]
        public void TestScaleSquare150Percent()
        {
            Square square = new Square(10, 10);
            square.Scale(150);
            Assert.AreEqual(15, square.Width);
            Assert.AreEqual(15, square.Height);
            
        }

        [TestMethod]
        public void TestScaleSquare100Percent()
        {
            Square square = new Square(10, 10);
            square.Scale(100);
            Assert.AreEqual(10, square.Width);
            Assert.AreEqual(10, square.Height);
        }

        [TestMethod]
        public void TestScaleSquare37Percent()
        {
            Square square = new Square(10, 15);
            square.Scale(37);
            Assert.AreEqual((decimal)3.7, square.Width);
            Assert.AreEqual((decimal)5.55, square.Height);           
        }

        [TestMethod]
        public void TestScaleRectangleUpAndDown()
        {
            Square square = new Square(10, 15);
            square.Scale(50);
            square.Scale(200);
            Assert.AreEqual(10, square.Width);
            Assert.AreEqual(15, square.Height);       
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleRectangleTo0Percent()
        {
            Square square = new Square(10, 15);
            square.Scale(0);       
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquareToNegativePercent()
        {
            Square square = new Square(15, 15);
            square.Scale(-5);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(3, 3);
            Assert.AreEqual(9, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(10, 10);
            Assert.AreEqual(100, square.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(15, 15);
            Assert.AreEqual(60, square.Perimeter());
        }

        [TestMethod]
        public void TestBiggerSquarePerimeter()
        {
            Square square = new Square(20, 20);
            Assert.AreEqual(80, square.Perimeter());
        }

       
    }
}
