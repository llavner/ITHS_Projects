namespace _03._Lägg_till_en_metod_som_returnerar_namnet_baklänges
{
    internal class Program
    {

        static void Main(string[] args)
        {

            MyPerson joakim = new MyPerson { firstName = "Joakim", lastName = "von Anka" };
            MyPerson kalle = new MyPerson { firstName = "Kalle", lastName = "Anka" };

            Console.WriteLine(joakim.GetFullNameReversed());

        }

        class MyPerson
        {
            public string firstName = "default name";
            public string lastName = "default last name";

            public string GetFullName()
            {

                return $"{firstName} {lastName}";

            }

            public string GetFullNameReversed()
            {
                string fullName = GetFullName();
                string reversedName = string.Empty;


                for (int i = fullName.Length -1; i >= 0; i--)
                {
                    reversedName += fullName[i];
                }

                return reversedName;
            }


        }
    }
}

