namespace _01._Slå_ihop_för__och_efternamn___skriv_ut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullName(firstName: "Marcus", lastName: "Renvall");
        }

        static void FullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
