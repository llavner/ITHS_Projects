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

namespace _06._Formulär_för_studenter
{
    //Utgå från XAML-uppgift 8 ("Formulär för studenter"), men ta bort "OK"-knappen.
    //Lägg till funktionalitet så att när man väljer en student i listan så visas den studentens förnamn, efternamn och email i formuläret till höger i fönstret;
    //och om man uppdaterar något i formuläret så uppdateras den studenten i listan.

    //OBS! Email visas inte i listan, men behöver ändå lagras så det nya värdet finns kvar när man växlar mellan studenterna via listan.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}