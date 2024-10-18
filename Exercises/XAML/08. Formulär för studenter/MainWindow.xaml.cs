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

namespace _08._Formulär_för_studenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] students = [ "Steve Harris", "Nicko McBrian", "Janick Gers", "Adrian Smith", "Dave Murray", "Bruce Dickenson" ];


        public MainWindow()
        {
            InitializeComponent();

            myListBox.ItemsSource = students;
        }
    }
}