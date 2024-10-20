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
using System.Windows.Shapes;

namespace _05._Färgblandare
{
    
    public partial class ColorPicker : Window
    {

        Color color = new Color();
        

        public ColorPicker()
        {
            InitializeComponent();
        }


        private void red_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            color.R = (byte)redSlider.Value;
            rectangle.Fill = new SolidColorBrush(color);

        }

        private void green_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            color.G = (byte)greenSlider.Value;
            rectangle.Fill = new SolidColorBrush(color);

        }

        private void blue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.B = (byte)blueSlider.Value;
            rectangle.Fill = new SolidColorBrush(color);
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cencelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void alpha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.A = (byte)alphaSlider.Value;
            rectangle.Fill = new SolidColorBrush(color);
        }
    }
}
