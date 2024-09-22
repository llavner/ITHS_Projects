namespace _01._Person_med_property_FirstName
{
    internal class Program
    {

        //Skapa en klass "Person" som har en private field _firstName, och en public property FirstName.När man sätter värdet på FirstName
        //ska detta sparas i _firstName, och när man läser värdet på FirstName ska den returnera det som finns lagrat i _firstName.

        static void Main(string[] args)
        {

            Person myself = new Person();

            myself.FirstName = "Marcus";

            Console.WriteLine(myself.FirstName);
            
        }
    }
}
