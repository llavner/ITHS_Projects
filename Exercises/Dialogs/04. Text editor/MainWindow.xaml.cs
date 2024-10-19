using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;

namespace _04._Text_editor
{

    //File->New
    //Om man har osparade ändringar, visa en dialogruta som frågar om man vill spara först:

    //YES: Spara filen om den redan har ett filnamn, annars visa en SaveFileDialog.Först när filen är sparad, töm textboxen.
    //NO: Töm textboxen (och sätt Title = "Untitled Document").
    //CANCEL: Avbryt, och låt användaren fortsätta editera den osparade texten.
    //    File->Save
    //Om det är en "Untitled Document", gör samma som File->Save As; annars spara filen med det filnamn den redan har.

    //File->Save As Visa en SaveFileDialog där det förvalda filnamnet i dialogboxen är det namn som filen redan har.
    //(Om det är en "Untitled Document", visa "Untitled Document.txt" som förvalt filnamn).

    //Lyssna på fönstrets Closing-event.
    //Om det finns osparade ändringar visa en MessageBox och hantera på liknande sätt som när man gör nytt dokument, men avsluta istället programmet.


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();

            if(result == true)
            {
                myTextbox.Text = File.ReadAllText(dialog.FileName); 
                window.Title = System.IO.Path.GetFileName(dialog.FileName);
            }

        }





        private void exitProgram_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Want to quit?", "Quit", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void newFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveFile_Click(object sender, RoutedEventArgs e)
        {



        }

        private void saveAsFile_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog dialog = new();
            var result = dialog.ShowDialog();

            if(result == true)
            {
                File.WriteAllText(dialog.FileName, myTextbox.Text);
            }
            

        }


    }
}