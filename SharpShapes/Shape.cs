using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

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
            BorderColor = Color.Tomato;
            FillColor = Color.Bisque;
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
        //abstract public void DrawOnto(Canvas ShapeCanvas, int x, int y)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Calculates the perimeter of he shape
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
