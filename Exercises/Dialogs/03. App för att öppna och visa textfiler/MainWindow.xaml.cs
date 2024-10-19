using Microsoft.Win32;
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

namespace _03._App_för_att_öppna_och_visa_textfiler
{
    //Skapa en applikation där hela fönstret består av en readonly TextBox.
    //Programmet ska ha en meny med en File->Open som visar en OpenFileDialog, och en File->Exit som avslutar programmet.

    //När användaren valt en fil i OpenFileDialog så ska filen läsas in och visas i TextBoxen.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fileOpen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void fileExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}