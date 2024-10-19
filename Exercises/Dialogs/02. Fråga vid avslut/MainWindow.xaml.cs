using System.ComponentModel;
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

namespace _02._Fråga_vid_avslut
{
    //Lyssna på fönstrets "Closing"-event och visa en MessageBox med frågan "Are you sure you want to quit?".
    //Om användaren väljer "No", avbryt stängning av fönstret genom att sätta Cancel = true på CancelEventArgs-objektet som skickas med när eventet triggas.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}