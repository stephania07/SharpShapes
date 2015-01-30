using SharpShapes;
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
        }

        public static int ArgumentCountFor(string className)
        {
            Type classType = Assembly.GetAssembly(typeof(Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First();
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return classConstructor.GetParameters().Length;
        }

        public static Shape InstantiateWithArguments(string className, object[] args)
        {
            Type classType = Type.GetType(className);
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return (Shape)classConstructor.Invoke(args);
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
            ShapeType.ItemsSource = classList;
        }

  

        private void ShapeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Enable/Disable Inputs based on the number of required arguments.
            string className = (String)ShapeType.SelectedValue;
            //Solution 2
            int argCount = ArgumentCountFor(className);
            Argument1.IsEnabled = true;
            Argument2.IsEnabled = (argCount > 1);
            Argument3.IsEnabled = (argCount > 2);
            Argument1.Clear();
            Argument2.Clear();
            Argument3.Clear();
            //Solution 1
            //int argCount = ArgumentCountFor(className);
            //    if(argCount ==1)
            //    {
            //        Argument2.IsEnabled = false;
            //        Argument3.IsEnabled = false;
            //    }
            //    else if (argCount == 2)
            //    {
            //        Argument2.IsEnabled = true;
            //        Argument3.IsEnabled = false;
            //    }
            //    else
            //    {
            //         Argument2.IsEnabled = true;
            //        Argument3.IsEnabled = true;
                
            //    }
        }
    }
}
