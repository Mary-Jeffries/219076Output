using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Shapes;

namespace _219076Output
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Don't put code here
            InitializeComponent();
            //Code here is ok - will only run when the window is created
            Console.WriteLine("hello");

            //This is a message box
            MessageBox.Show("I am a message box text!",
                "I am a caption",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Warning);

            Label mylabel = new Label();
            mylabel.Content = "Whoo hoo - my new label";
            spStack.Children.Add
        }  
    }
}
