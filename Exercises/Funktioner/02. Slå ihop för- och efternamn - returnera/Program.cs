namespace _02._Slå_ihop_för__och_efternamn___returnera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = FullName("Marcus", "Renvall");
            Console.WriteLine(name);
        }

        static string FullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
