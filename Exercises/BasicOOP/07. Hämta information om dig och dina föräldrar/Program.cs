namespace _07._Hämta_information_om_dig_och_dina_föräldrar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myself = new Person() { firstName = "Marcus", lastName = "Renvall" };

            //myself.father = new Person() { firstName = "Leif", lastName = "Renvall" };

            //myself.mother = new Person() { firstName = "Hillevi", lastName = "Bark" };

            //myself.father.father = new Person() { firstName = "Lage", lastName = "Renvall" };

            Console.WriteLine(myself.GetSelfAndParents());
            Console.WriteLine();
        }

        class Person
        {
            public string firstName = string.Empty;
            public string lastName = string.Empty;

            public Person mother;
            public Person father;

            public string GetFullName()
            {
                return $"Name: {firstName} {lastName}";
            }

            public string GetSelfAndParents()
            {
                if (father == null)
                {
                    father = new Person { firstName = "Unknown" };
                }
                if (mother == null)
                {
                    mother = new Person { firstName = "Unknown" };
                }

                string returnedValue = $"Name = {firstName} {lastName}\nMother = {mother.firstName} {mother.lastName}\nFather = {father.firstName} {father.lastName}";
                return returnedValue;

            }
        }
    }
}
