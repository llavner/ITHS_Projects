using System.Reflection.Emit;
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

namespace _04._Label_med_valbar_position
{
    //Skapa ett nytt program med en label som visar sin egen x- och y-position (T.ex: "x = 43, y= 89")
    //Skapa en slider för att ställa in x-positionen mellan 0-100, och en slider som gör det samma för y-positionen.
    //När man drar i sliders så ska labelns position uppdateras.D.v.s både texten som skrivs i labeln så den reflekterar valda värden
    //på x och y; och dessutom labelns faktiska position i fönstret.

    //Bonus: Lägg gärna till en label i anslutning till vardera slider så att det tydligt framgår vad varje slider gör.T.ex: "x-position:", respektive "y-position:"


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}