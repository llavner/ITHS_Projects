namespace _01._Skriva_ut_namn_på_personer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName.
            //Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.

            MyPerson joakim = new MyPerson { firstName = "Joakim", lastName = "von Anka" };
            MyPerson kalle = new MyPerson { firstName = "Kalle", lastName = "Anka" };

            joakim.Presentation();
            Console.WriteLine();
            kalle.Presentation();

        }

        public string GetFullName(string firstName, string lastName)
        {
            string fullName = $"Förnamn: {firstName}\nEfternamn: {lastName}";

            return fullName;

        }


        class MyPerson
        {
            public string firstName = "default name";
            public string lastName = "default last name";

            public void Presentation()
            {
                Console.WriteLine($"Förnamn: {firstName}\nEfternamn: {lastName}");
            }
        }
    }
}
