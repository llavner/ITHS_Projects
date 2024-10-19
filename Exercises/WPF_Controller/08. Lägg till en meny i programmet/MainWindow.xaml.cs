using System.Collections.Generic;
using System.Security.Cryptography;
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

namespace _08._Lägg_till_en_meny_i_programmet
{
    //Man kan skapa menyer med <Menu> och <MenuItem>.
    //Lägg till en meny i toppen av student appen med "File" och "Edit".
    //Under "File" ska det finnas ett "Exit" alternativ som avslutar programmet om man klickar på den.
    //Under "Edit" ska det finnas en "Add Student" och en "Remove Student"; dessa ska fungera likadant som knapparna från förra uppgiften.

    //OBS! Knapparna ska fortfarande finnas kvar och fungera som tidigare.Om ingen student är markerad i listan så måste både "Remove"-knappen,
    //och motsvarande meny-alternativ bli "disabled".



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}