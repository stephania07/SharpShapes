﻿using SharpShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Drawing;


namespace GrapeShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            PopulateClassList();
            DrawRectangle();
            DrawSquare(1, 50, new Square(30));
            Square square = new Square(200);
            square.FillColor = System.Drawing.Color.Navy;
            square.BorderColor = System.Drawing.Color.Fuchsia;
            DrawSquare(50, 5, square);
        }


        private void PopulateClassList()
        {
            var classList = new List<string>();
            var shapeType = typeof(Shape);
            foreach (Type type in Assembly.GetAssembly(shapeType).GetTypes())
            {
                if (type.IsSubclassOf(shapeType) && !type.IsAbstract)
                {
                    classList.Add(type.Name);
                }
            }
            ShapeTypeCombobox.ItemsSource = classList;
        }
        private void DrawRectangle() 
        {
            System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Tomato;
            myPolygon.Fill = System.Windows.Media.Brushes.Bisque;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(1, 50);
            System.Windows.Point Point2 = new System.Windows.Point(1, 80);
            System.Windows.Point Point4 = new System.Windows.Point(50, 80);
            System.Windows.Point Point3 = new System.Windows.Point(50, 50);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPolygon.Points = myPointCollection;
            ShapeCanvas.Children.Add(myPolygon);

            //Cirlce myCircle = new Circle();
            //myCircle.Stroke = System.Windows.Media.Brushes.Tomato;
            //myCircle.Fill = System.Windows.Media.Brushes.Bisque;
            //myCircle.StrokeThickness = 2;
            //myCircle.HorizontalAlignment = HorizontalAlignment.Left;
            //myCircle.VerticalAlignment = VerticalAlignment.Center;
            //System.Windows.Point Point1 = new System.Windows.Point(1, 50);
            //System.Windows.Point Point2 = new System.Windows.Point(1, 80);
            //System.Windows.Point Point3 = new System.Windows.Point(50, 80);
            //System.Windows.Point Point4 = new System.Windows.Point(50, 50);
            //PointCollection myPointCollection = new PointCollection();
            //myPointCollection.Add(Point1);
            //myPointCollection.Add(Point2);
            //myPointCollection.Add(Point3);
            //myPointCollection.Add(Point4);
            //myPolygon.Points = myPointCollection;
            //ShapeCanvas.Children.Add(myCircle);
        
        }
        private void DrawSquare(int x, int y, Square square)
        { 
            System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Green;
            myPolygon.Fill = System.Windows.Media.Brushes.LightBlue;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(x, y);
            System.Windows.Point Point2 = new System.Windows.Point(x + (double)square.Width, y);
            System.Windows.Point Point3 = new System.Windows.Point(x+ (double)square.Width, y+ (double)square.Width);
            System.Windows.Point Point4 = new System.Windows.Point(x, y + (double)square.Width);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPolygon.Points = myPointCollection;
            ShapeCanvas.Children.Add(myPolygon);
        
        }
    }
}
