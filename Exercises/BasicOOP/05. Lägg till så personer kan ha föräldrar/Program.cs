namespace _05._Lägg_till_så_personer_kan_ha_föräldrar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPerson myself = new MyPerson() { firstName = "Marcus", lastName = "Renvall"};

            

            Console.WriteLine(myself.GetFullName());
        }

        class MyPerson
        {
            public string firstName = "default name";
            public string lastName = "default lastname";

            public MyPerson mother;
            public MyPerson father;

            public string GetFullName()
            {
                return $"Firstname:{firstName}\nLastname:{lastName}";
            }
        }
    }
}
