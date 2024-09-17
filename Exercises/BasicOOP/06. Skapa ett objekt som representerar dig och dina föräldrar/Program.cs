namespace _06._Skapa_ett_objekt_som_representerar_dig_och_dina_föräldrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myself = new Person() { firstName = "Marcus", lastName = "Renvall"};

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
                    father = new Person { firstName = "Okänd" }; 
                }
                if(mother == null)
                {
                    mother = new Person { firstName = "Okänd" };
                }
                
                string returnedValue = $"Mitt namn = {firstName} {lastName}\nMother = {mother.firstName} {mother.lastName}\nFather = {father.firstName} {father.lastName}";
                return returnedValue;
                
            }
        }
    }
}
