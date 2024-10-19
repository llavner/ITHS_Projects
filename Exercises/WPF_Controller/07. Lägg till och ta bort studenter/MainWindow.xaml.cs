using System.Collections.Generic;
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

namespace _07._Lägg_till_och_ta_bort_studenter
{
    //Uppdatera programmet i uppgift 6 med en knapp för att lägga till, och en knapp för att ta bort studenter.
    //Om ingen student är vald("selected") i listan så ska "ta bort"-knappen vara inaktiverad(disabled); annars ska den valda studenten tas bort när man klickar på "ta bort"-knappen.

    //Om man klickar på "lägg till"-knappen så lägg till en ny student i listan med förnamn "New", och tomma strängar för efternamn och email.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}