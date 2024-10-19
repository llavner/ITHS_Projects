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

namespace _02._Räkna_upp_och_ner_i_en_label_
{ 
    //Gör ett program med en label som initialt visar värdet 5. Det ska finna en knapp "Increase" och en knapp "Decrease".
    //Genom att klicka på knapparna ska man kunna öka eller minska värdet som visas på label, ett steg i taget.
    //Värdet ska dock aldrig kunna bli lägre än 0, eller högre än 9.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int counter = 5;
        private void increase_Click(object sender, RoutedEventArgs e)
        {
            if(counter < 9)
            myLabel.Content = counter++;

        }

        private void decrease_Click(object sender, RoutedEventArgs e)
        {
            if(counter > 0)
            myLabel.Content = counter--;
        }
    }
}