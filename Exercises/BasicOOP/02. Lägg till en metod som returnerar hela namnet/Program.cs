namespace _02._Lägg_till_en_metod_som_returnerar_hela_namnet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyPerson joakim = new MyPerson { firstName = "Joakim", lastName = "von Anka" };
            MyPerson kalle = new MyPerson { firstName = "Kalle", lastName = "Anka" };

            Console.WriteLine(joakim.GetFullName());
            
        }

        class MyPerson
        {
            public string firstName = "default name";
            public string lastName = "default last name";

            public string GetFullName()
            {

                return $"{firstName} {lastName}";

            }

           
        }
    }
}
