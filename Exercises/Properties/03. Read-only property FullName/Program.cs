namespace _03._Read_only_property_FullName
{
    internal class Program
    {

        //Lägg sedan till en publik property FullName som är read only (bara get;) När man läser av propertynså ska den returnera hela namnet.
        //Testa koden genom att skapa ett objekt, tilldela värden på både FirstName och LastName, och sedan skriva ut FullName.
        static void Main(string[] args)
        {
            Person myself = new Person();

            myself.FirstName = "Marcus";
            myself.LastName = "Renvall";

            Console.WriteLine($"{myself.FullName}");
        }
    }
}
