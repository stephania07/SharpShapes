﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;
using System.Drawing;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestSharpShapes
{
   
    [TestClass]
    public class UnitTestShape
    {
        public class MyShape : Shape
        {
            public override int SidesCount
            {
                get 
                { 
                    throw new NotImplementedException(); 
                }
            }
            [TestMethod]
            public override void DrawOnto(Canvas ShapeCanvas, int x, int y)
            {
                throw new NotImplementedException();

            }
            public override void Scale(int percent)
            {
               throw new NotImplementedException();
            }
            public override decimal Perimeter()
            {
                throw new NotImplementedException();
            }
            public override decimal Area()
            {
                throw new NotImplementedException();
            }
           
        }
        [TestMethod]
        public void TestSettingBorderColor()
        {
            Shape shape = new MyShape();
            shape.BorderColor = Color.AliceBlue;
            Assert.AreEqual(Color.AliceBlue, shape.BorderColor);
        }
        [TestMethod]
        public void TestDefaultBorderColor()
        {
            Shape shape = new MyShape();
            Assert.AreEqual(Color.Tomato, shape.BorderColor);
        }
        [TestMethod]
        public void TestSettingFillColor()
        {
            Shape shape = new MyShape();
            shape.FillColor = Color.AliceBlue;
            Assert.AreEqual(Color.AliceBlue, shape.FillColor);
        }
        [TestMethod]
        public void TestDefaultFillColors()
        {
            Shape shape = new MyShape();
            Assert.AreEqual(Color.Bisque, shape.FillColor);
        }
       
    }
}
