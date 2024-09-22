namespace _05._Lägg_till_så_personer_kan_ha_föräldrar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myself = new Person() { firstName = "Marcus", lastName = "Renvall"};

            Console.WriteLine(myself.GetFullName());
        }

        class Person
        {
            public string firstName = "default name";
            public string lastName = "default lastname";

            public Person mother;
            public Person father;

            public string GetFullName()
            {
                return $"Firstname:{firstName}\nLastname:{lastName}";
            }
        }
    }
}
