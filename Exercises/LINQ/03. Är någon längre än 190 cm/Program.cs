namespace _03._Är_någon_längre_än_190_cm
{

    //Är någon av personerna mellan 20 och 40 år längre än 190 cm lång?
    internal class Program
    {
        static void Main(string[] args)
        {

            var people = new[]
            {
                new { Firstname = "Marcus", Lastname = "Renvall", Age= 44, Height = 172, Weight = 86 },
                new { Firstname = "Lars", Lastname = "Larsson", Age = 25, Height = 187, Weight = 89 },
                new { Firstname= "Lisa", Lastname = "Tonåringsson",Age = 14, Height = 132, Weight = 56 },
                new { Firstname = "Bengt", Lastname = "Gamlemanson", Age = 88, Height = 175, Weight = 80 },
                new { Firstname = "Lage", Lastname = "Bertilsson", Age= 44, Height = 172, Weight = 86 },
                new { Firstname = "Karl Pedal", Lastname = "Karlsson", Age = 34, Height = 192, Weight = 85 },
                new { Firstname= "Tage", Lastname = "Danielsson",Age = 77, Height = 170, Weight = 71 },
                new { Firstname = "Knut", Lastname = "Evighetsson", Age = 102, Height = 165, Weight = 60 }

            };


            var result = people.Where(p => p.Age >= 20 && p.Age <= 40 && p.Height > 190);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Firstname} is {item.Age} years old and {item.Height} cm tall.");
            }

        }
    }
}
