using static _02._Använd_generiskt_delegat.Program;

namespace _02._Använd_generiskt_delegat
{

    //Ändra koden i uppgiften ovan så att den använder ett generiskt delegat istället för den du själv deklarerade.
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
    }
}
