using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        //http://mathworld.wolfram.com/IsoscelesTrapezoid.html
        // type 'trapezoid calc find a' in google to find either perimeter or area
          public void TestTrapezoidConstructorSetsProperties()
        {
            Trapezoid trapezoid = new Trapezoid(8, 2, 4);
            Assert.AreEqual(8, trapezoid.LongBase);
            Assert.AreEqual(2, trapezoid.ShortBase);
            Assert.AreEqual(4, trapezoid.Height);
        }

        [TestMethod]
        public void TestTrapezoidConstructorSetsProperties2()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 2);
            Assert.AreEqual(20, trapezoid.LongBase);
            Assert.AreEqual(15, trapezoid.ShortBase);
            Assert.AreEqual(2, trapezoid.Height);
        }

       [TestMethod]
      public void TestTrapezoidConstructorCalculatorAngles1()
        {
            Trapezoid trapezoid = new Trapezoid(8, 4, 2);
            Assert.AreEqual(45, trapezoid.AcuteAngle);
            Assert.AreEqual(135, trapezoid.ObtuseAngle);
         }

       [TestMethod]
       public void TestTrapezoidConstructorCalculatorAngles2()
       {
           Trapezoid trapezoid = new Trapezoid(20, 15, 2);
           Assert.AreEqual((decimal)38.66, trapezoid.AcuteAngle);
           Assert.AreEqual((decimal)141.34, trapezoid.ObtuseAngle);
       }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksBaseLength()
        {
            Trapezoid trapezoid = new Trapezoid(15, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksLongBaseLengths()
        {
            Trapezoid trapezoid = new Trapezoid(0, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidTrapezoidCantBeRectangle()
        {
            Trapezoid trapezoid = new Trapezoid(20, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksShortBaseLength()
        {
            Trapezoid trapezoid = new Trapezoid(15, 0, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSaintyChecksHeight()
        {
           Trapezoid trapezoid = new Trapezoid(15, 20, 0);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestTrapezoidConstructorSaintyChecksBase2Negativity()
        //{
        //    Trapezoid trapezoid = new Trapezoid(2, -4, 5);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestTrapezoidConstructorSaintyChecksHeightNegativity()
        //{
        //    Trapezoid trapezoid = new Trapezoid(2, 4, -5);
        //}

        [TestMethod]
        public void TestScaleTrapezoid200Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(200);
            Assert.AreEqual(40, trapezoid.LongBase);
            Assert.AreEqual(30, trapezoid.ShortBase);
            Assert.AreEqual(20, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestScaleTrapezoid150Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(150);
            Assert.AreEqual(30, trapezoid.LongBase);
            Assert.AreEqual((decimal)22.5, trapezoid.ShortBase);
            Assert.AreEqual(15, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestScaleTrapezoid100Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(100);
            Assert.AreEqual(20, trapezoid.LongBase);
            Assert.AreEqual(15, trapezoid.ShortBase);
            Assert.AreEqual(10, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestScaleTrapezoid37Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(37);
            Assert.AreEqual((decimal)7.4, trapezoid.LongBase);
            Assert.AreEqual((decimal)5.55, trapezoid.ShortBase);
            Assert.AreEqual((decimal)3.7, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleTrapezoid0Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleRectangleToNegativePercent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(-10);
        }

        [TestMethod]
        public void TestSidesCount()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            Assert.AreEqual(4, trapezoid.SidesCount);           
        }

        //[TestMethod]
        //public void TestTrapezoidArea()
        //{
        //    Trapezoid trapezoid = new Trapezoid(5, 8, 2);
        //    Assert.AreEqual(13, trapezoid.Area());
        //}

        //[TestMethod]
        //public void TestBiggerTrapezoidArea()
        //{
        //    Trapezoid trapezoid = new Trapezoid(10, 6, 4);
        //    Assert.AreEqual(52, trapezoid.Area());          
        //}

        //[TestMethod]
        //public void TestTrapezoidPerimeter()
        //{
        //    Trapezoid trapezoid = new Trapezoid(5, 8, 2);
        //    Assert.AreEqual(16.61, trapezoid.Perimeter());       
        //}

        //[TestMethod]
        //public void TestDefaultTrapezoidColors()
        //{
        //    Trapezoid trapezoid = new Trapezoid(20, 15, 2);
        //    Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
        //    Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
        //}

    }
}
