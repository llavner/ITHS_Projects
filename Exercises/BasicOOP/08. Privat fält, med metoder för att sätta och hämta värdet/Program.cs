namespace _08._Privat_fält__med_metoder_för_att_sätta_och_hämta_värdet_
{
    internal class Program
    {

        //Uppdatera klassen med ett fält, private double length, som kan lagra längden på personen.
        //Eftersom denna är markerad som private kommer man inte kunna läsa/skriva denna utanför klassen.
        //Lägg därför till en metod void SetLength(double length) som sätter värdet på det privat fältet length,
        //samt en double GetLength() som returnerar värdet på fältet length.

        //När du är klar ska följande kod ge utskriften 1.82

        static void Main(string[] args)
        {
            Person myself = new Person() { firstName = "Marcus", lastName = "Renvall" };
            //myself.father = new Person() { firstName = "Leif", lastName = "Renvall" };
            myself.mother = new Person() { firstName = "Hillevi", lastName = "Bark" };
            //myself.father.father = new Person() { firstName = "Lage", lastName = "Renvall" };

            Person newPerson = new Person();

            newPerson.SetLength(1.82);

            Console.WriteLine(newPerson.GetLength());

        }

        class Person
        {
            public string firstName = string.Empty;
            public string lastName = string.Empty;

            public Person mother;
            public Person father;

            private double _length;

            public void SetLength(double length) { _length = length; } //setter

            public double GetLength() { return _length;} //getter

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

                string returnedValue = $"My name = {firstName} {lastName}\nMother = {mother.firstName} {mother.lastName}\nFather = {father.firstName} {father.lastName}";
                return returnedValue;

            }
        }
    }
}

