namespace _02._Autoproperty_LastName
{
    internal class Program
    {
        //Lägg till en publik auto-property LastName som går att både läsa och skriva.
        static void Main(string[] args)
        {
            Person myself = new Person();

            myself.FirstName = "Marcus";
            myself.LastName = "Renvall";

            Console.WriteLine($"{myself.FirstName} {myself.LastName}");
        }
    }
}
