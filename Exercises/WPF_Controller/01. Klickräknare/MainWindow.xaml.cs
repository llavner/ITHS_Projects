using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01._Klickräknare
{
    //Bygg ett program med en knapp som håller reda på hur många gånger man klickat på den.
    //Det ska stå "Click: X" på knappen, där X är antalet gånger man klickat på knappen.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
        }

        public int counter = 1;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            

            myButton.Content = $"Click: {counter++}";
        }
    }
}