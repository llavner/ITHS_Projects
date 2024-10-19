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

namespace _01._Meddelande_vid_uppstart
{
    //Använd MessageBox i fönstrets konstruktor för att visa meddelandet "Application is about to start!".
    //Visa ytterligare en MessageBox när fönstrets "Loaded"-event triggas där du skriver "Application started!".

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("Application is about to start!");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Application started!");
        }
    }
}