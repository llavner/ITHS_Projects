namespace _06._Skapa_ett_objekt_som_representerar_dig_och_dina_föräldrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myself = new Person() { firstName = "Marcus", lastName = "Renvall"};

            

            myself.father = new Person() { firstName = "Leif", lastName = "Renvall" };
            myself.father.father = new Person() { firstName = "Lage", lastName = "Renvall" };
            myself.father.mother = new Person() { firstName = "Lisa", lastName = "Renvall" };

            myself.mother = new Person() { firstName = "Hillevi", lastName = "Bark" };
            myself.mother.father = new Person() { firstName = "Selim", lastName = "Andersson" };
            myself.mother.mother = new Person() { firstName = "Rut", lastName = "Andersson" };



            Console.WriteLine(myself.mother.GetFullName());
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

            
        }
    }
}
