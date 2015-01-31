using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;


namespace SharpShapes
{
    public class Trapezoid : Quadrilateral
    {
        //private int longBase;
        public decimal LongBase { get; private set;}

       // private int shortBase;
        public decimal ShortBase { get; private set; }

        //private int height;
        public decimal Height { get; private set; }

        public decimal ObtuseAngle { get; private set; }
        public decimal AcuteAngle { get; private set; }

        public Trapezoid(int longBase, int shortBase, int height)
        {
            if (height <= 0 || shortBase <= 0 || longBase <= 0 || shortBase >= longBase)
            {
                throw new ArgumentException();
            }
           
            this.LongBase = longBase;
            this.ShortBase = shortBase;
            this.Height = height;

            decimal wingLength = (LongBase - ShortBase) / 2;
            this.AcuteAngle = Decimal.Round((decimal)(Math.Atan
                ((double)(height / wingLength)) * (180.0 / Math.PI)), 2);
            this.ObtuseAngle = 180 - AcuteAngle;
        }
         public override void DrawOnto(System.Windows.Controls.Canvas ShapeCanvas, int x, int y)
        {
            System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Tomato;
            myPolygon.Fill = System.Windows.Media.Brushes.Bisque;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            Point point1 = new Point(x, y);
            Point point2 = new Point(x + (double)ShortBase, y);
            Point point3 = new Point(x + (double)((LongBase + ShortBase)/2), y + (double)Height);
            Point point4 = new Point(x - (double)((LongBase - ShortBase)/2), y+ (double)Height);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(point1);
            myPointCollection.Add(point2);
            myPointCollection.Add(point3);
            myPointCollection.Add(point4);

            myPolygon.Points = myPointCollection;
            ShapeCanvas.Children.Add(myPolygon);
           
        }
    
        public override int SidesCount
        {
            get { return 4; } 
        }

        public override decimal Area()
        {
            return (LongBase + ShortBase) / 2 * Height;
        }

        //http://www.mathopenref.com/coordtrapareaperim.html
        public override decimal Perimeter()
        {
            double squares = (double)(WingLength() * WingLength() + Height * Height);
            decimal legLength = Decimal.Round((decimal)Math.Sqrt(squares), 2);
            return LongBase + ShortBase + 2 * legLength;
        }

        private decimal WingLength()
        {
            return (LongBase - ShortBase) / 2;
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            this.LongBase = LongBase * percent / 100;
            this.ShortBase = ShortBase * percent / 100;
            this.Height = Height * percent / 100;
        }


    }
}
