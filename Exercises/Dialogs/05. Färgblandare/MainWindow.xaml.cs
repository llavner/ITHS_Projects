using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
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

namespace _05._Färgblandare
{

    //1. Skapa ett nytt program som har en knapp "Choose Color". När man klickar på knappen ska en ny dialogruta öppnas.

    //Lägg till ett nytt WPF-fönster i ditt projekt.Detta ska bli dialogrutan som öppnas från huvudfönstret.
    //Gör dialogrutan lagom stor för att få plats med en <Rectangle> som visar den mixade färgen;
    //3 slider som representerar värden för Rött, Grönt, Blått; samt två knappar "Cancel" och "OK".

    //På<Rectangle> kan du använda properties "Width" och "Height" för att sätta storleken;
    //"Fill" och "Stroke" för att sätta färgen på rektangeln och rektangelns kantlinje.Det finns även en "StrokeThickness"-property.

    //Datorer använder oftast 24-bitars färgvärden, där färgen mixas av grundfärgerna Rött, Grönt, och Blått(8 bitar var).
    //Ofta används även ytterligare ett 8-bitas värde för "Alpha", vilket representerar genomskinlighet.
    //En färg med Alpha-värde 255 (högsta värdet) är helt ogenomskinlig, d.v.s man ser inget av bakgrunden igenom färgen.En färg med "Alpha"-värde 0 syns inte alls, utan man ser bara bakgrunden.
    //Är Alpha-värdet 128 så är den en 50/50 blandning mellan bakgrunden och t.ex rektangeln som målas med färgen.
    //Dina 3 <Slider> ska alltså representer Rött, Grön, och Blått. Ha gärna en<Label> i anslutning till varje som visar för användaren vilken färg det är.
    //Varje<Slider> ska kunna ställas till heltal från 0 till 255. När man ändrar värdet på någon av dem så ska färgen på rektangeln uppdateras för att visa den mixade färgen.

    //I code-behind skapa en "new Color()" med R, G, och B properties satt efter värden på dina 3 <Slider>. Kom även ihåg att sätta A-propertyn (alpha) till 255,
    //annars syns inte din färg (default 0).
    //Skapa sedan en "new SolidColorBrush(myColor)" och använd den för rektangelns "Fill"-property.
    //Om du fått rektangeln att ändra färg när man drar i sliders så är du nästan klar.


    //Lägg till en publik SolidColorBrush-property i din dialogbox som returnerar färgen,
    //så att den går att läsa av efter vi stängt dialogboxen.Man ska även kunna sätta propertyn så att de 3 sliders initialisera med rätt RGB-värden,
    //och rätt färg visas i rutan.
    //Gör så att knapparna sätter fönstrets DialogResult till false respektive true, samt stänger fönstret.






    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void colorButton_Click(object sender, RoutedEventArgs e)
        {

            ColorPicker colorPicker = new ColorPicker();
            colorPicker.Show();

        }

    }
}