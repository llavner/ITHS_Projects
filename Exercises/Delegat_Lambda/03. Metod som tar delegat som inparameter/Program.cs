namespace _03._Metod_som_tar_delegat_som_inparameter
{

    //Skriv en ny metod som också tar firstName och lastName. Denna metoden ska returnera en sträng som innehåller variabelnamnen och dess värden på två rader.

    //Exempel:
    //firstName: Fredrik
    //lastName: Johansson

    //Skriv sedan en metod som tar ett generiskt delegat (som matchar metoden ovan) som inparameter.
    //Metoden ska, i tur och ordning, anropa delegatet med 3 olika för- och efternamn och skriva ut resultatet.
    //Testa att anropa denna metod först med en referens till metoden i uppgift 1 och sedan med metoden ovan (uppgift 3).

       

    internal class Program
    {
        static void Main(string[] args)
        {

            Func<string, string, string> WriteFullName = FullName;
            Func<string, string, string> NameTwoRows = FullNameTwoRows;

            Console.WriteLine(WriteFullName("Marcus", "Renvall"));
            Console.WriteLine();
            Console.WriteLine(NameTwoRows("Bruce", "Dickenson"));
         
        }

        public static string FullName(string firstName, string lastName)
        {

            return $"{firstName} {lastName}";

        }

        public static string FullNameTwoRows(string firstName, string lastName)
        {

            return $"firstName: {firstName}\nlastName: {lastName}";

        }

        /*public static string AllNames(Func<string,string,string> myDelegate)
        {

        
        }*/


    }
}
