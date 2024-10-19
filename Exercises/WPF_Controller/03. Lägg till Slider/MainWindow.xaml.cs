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

namespace _03._Lägg_till_Slider
{
    //Uppdatera programmet i uppgift 2 så att det även finns en slider som kan sättas från 0 till 9 (i hela steg, alltså endast heltal).
    //Om man flyttar slidern så kan värdet på labeln ändras. Observera att knapparna fortfarande ska finnas kvar, fungera som förut, och även uppdatera slidern.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
     
        }
        int counter = 5;
        private void increase_Click(object sender, RoutedEventArgs e)
        {
            if (counter < 9)
                myLabel.Content = counter += 1;

        }

        private void decrease_Click(object sender, RoutedEventArgs e)
        {
            if (counter > 0)
                myLabel.Content = counter -= 1;
        }
    }
}