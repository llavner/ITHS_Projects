namespace _04._Filtrera_på_namn
{

    //Filtrera arrayen från uppgift 1 så att du får en ny lista med endast de användare vars förnamn är längre än efternamnet
    //(d.v.s större antal bokstäver). I den nya listan vill vi att objekten ska ha endast properties FirstName och LastName.

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
