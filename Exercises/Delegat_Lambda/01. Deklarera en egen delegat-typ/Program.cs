namespace _01._Deklarera_en_egen_delegat_typ
{

    //Skriv en metod som tar två strängar: firstName och lastName. Metoden ska returnera en ny sträng som är hela namnet.
    //Deklarera en delegat-typ, och gör en variabel som är en referens till metoden. Anropa metoden via delegatet.

    internal class Program
    {
        public delegate string WriteFullName(string firstName, string lastName);

        static void Main(string[] args)
        {
            //WriteFullName WriteFullName = new WriteFullName(FullName);
            WriteFullName WriteFullName = FullName;

            //Console.WriteLine(WriteFullName.Invoke("Marcus", "Renvall"))
            Console.WriteLine(WriteFullName("Marcus", "Renvall"));
        }

        public static string FullName(string firstName, string lastName)
        {

            return $"{firstName} {lastName}";

        }

    }
}
