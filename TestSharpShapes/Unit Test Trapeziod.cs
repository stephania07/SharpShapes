using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(5, trapezoid.Base1);
            Assert.AreEqual(8, trapezoid.Base2);
            Assert.AreEqual(2, trapezoid.Height);
         }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksBase1Positivity()
        {
            Trapezoid trapezoid = new Trapezoid(-2, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksBase2Positivity()
        {
            Trapezoid trapezoid = new Trapezoid(2, -4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksHeightPositivity()
        {
            Trapezoid trapezoid = new Trapezoid(2, 4, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksBase1Negativity()
        {
           Trapezoid trapezoid = new Trapezoid(-2, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksBase2Negativity()
        {
            Trapezoid trapezoid = new Trapezoid(2, -4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksHeightNegativity()
        {
            Trapezoid trapezoid = new Trapezoid(2, 4, -5);
        }

        [TestMethod]
        public void TestScaleTrapezoid200Percent()
        {
            Trapezoid trapezoid = new Trapezoid(10, 20, 30);
            trapezoid.Scale(200);
            Assert.AreEqual(10, trapezoid.Base1);
            Assert.AreEqual(20, trapezoid.Base2);
            Assert.AreEqual(30, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid150Percent()
        {
            Trapezoid trapezoid = new Trapezoid(10, 20, 30);
            trapezoid.Scale(150);
            Assert.AreEqual(15, trapezoid.Base1);
            Assert.AreEqual(30, trapezoid.Base2);
            Assert.AreEqual(45, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid100Percent()
        {
            Trapezoid trapezoid = new Trapezoid(10, 20, 30);
            trapezoid.Scale(100);
            Assert.AreEqual(10, trapezoid.Base1);
            Assert.AreEqual(20, trapezoid.Base2);
            Assert.AreEqual(30, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid37Percent()
        {
            Trapezoid trapezoid = new Trapezoid(10, 20, 30);
            trapezoid.Scale(37);
            Assert.AreEqual(1.85, trapezoid.Base1);
            Assert.AreEqual(2.96, trapezoid.Base2);
            Assert.AreEqual(0.74, trapezoid.Height);
        }

        [TestMethod]
        public void TestScaleTrapezoid0Percent()
        {
            Trapezoid trapezoid = new Trapezoid(10, 20, 30);
            trapezoid.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleRectangleToNegativePercent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(-9);
        }

        [TestMethod]
        public void TestSidesCount()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(4, trapezoid.SidesCount);           
        }

        [TestMethod]
        public void TestTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(13, trapezoid.Area());
        }

        [TestMethod]
        public void TestBiggerTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(10, 6, 4);
            Assert.AreEqual(52, trapezoid.Area());          
        }

        [TestMethod]
        public void TestTrapezoidPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(16.61, trapezoid.Perimeter());       
        }

        //[TestMethod]
        //public void TestTrapezoidBiggerPerimeter();
        //{
        //   Trapezoid trapezoid = new Trapezoid(10, 6, 4);
        //   Assert.AreEqual( , trapezoid.Perimeter());
        //}

    }
}
