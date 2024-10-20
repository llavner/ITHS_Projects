namespace _01._Anonyma_datatyper
{

    //Skapa en array "people" med anonyma datatyper. Varje objekt i arrayen ska ha följande properties: FirstName, LastName, Age, Height, Weight.
    //Lägg till minst 8 sådana objekt i arrayen.
    //Använd dig sedan av LINQ för att lösa följande uppgifter: 02 - 13


    internal class Program
    {
        static void Main(string[] args)
        {

            var people = new[]
            {
                new { Firstname = "Marcus", Lastname = "Renvall", Age= 44, Height = 172, Weight = 86 },
                new { Firstname = "Lars", Lastname = "Larsson", Age = 65, Height = 187, Weight = 89 },
                new { Firstname= "Lisa", Lastname = "Tonåringsson",Age = 14, Height = 132, Weight = 56 },
                new { Firstname = "Bengt", Lastname = "Gamlemanson", Age = 88, Height = 175, Weight = 80 },
                new { Firstname = "Lage", Lastname = "Bertilsson", Age= 44, Height = 172, Weight = 86 },
                new { Firstname = "Karl Pedal", Lastname = "Karlsson", Age = 34, Height = 182, Weight = 85 },
                new { Firstname= "Tage", Lastname = "Danielsson",Age = 77, Height = 170, Weight = 71 },
                new { Firstname = "Knut", Lastname = "Evighetsson", Age = 102, Height = 165, Weight = 60 }

            };

        }

    }


}

