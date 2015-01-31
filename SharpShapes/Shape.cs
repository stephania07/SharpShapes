﻿using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SharpShapes
{
    abstract public class Shape
    {
        
        //Eg. individual properties could be fill color...
        /// <summary>
        /// Specifies the color of the interior of the shape.
        /// </summary>
        public Color FillColor { get; set; }

        /// <summary>
        /// Specifies the color of the border of the shape, when drawn
        /// </summary>
        public Color BorderColor { get; set; }


        //virtual means can be overiden by subclass
        /// <summary>
        /// The number of sides of this shape
        /// </summary>
        /// //abstract here is because it is different for every shape
        abstract public int SidesCount { get; }//as length in js 

        public Shape()
        {
            BorderColor = Colors.Tomato;
            FillColor = Colors.Bisque;
        }

         /// <summary>
         /// Calculates the area of the shape.
         /// </summary>
         /// <returns>the area of the shape</returns>
        abstract public decimal Area();

        /// <summary>
        /// Creates a polygon representing this shape and adds it to the ShapeCanvas.
        /// </summary>
        /// <param name="ShapeCanvas">The Canvas on which to draw this Shape.</param>
        /// <param name="x">The x-coordinate on which to place the upper-left corner of the shape.</param>
        /// <param name="y">The y-coordinate on which to place the upper-left corner of the shape.</param>
        abstract public void DrawOnto(Canvas ShapeCanvas, int x, int y);
       

        /// <summary>
        /// Calculates the perimeter of the shape
        /// </summary>
        /// <returns>the perimeter of the shape</returns>
        abstract public decimal Perimeter();
    
        /// <summary>
        /// Scales the shape in size
        /// </summary>
        /// <param name="percent">the percentage by which to scale the shape</param>
        abstract public void Scale(int percent);

       
    }
}
