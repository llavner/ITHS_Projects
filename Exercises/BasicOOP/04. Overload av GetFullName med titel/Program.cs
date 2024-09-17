namespace _04._Overload_av_GetFullName_med_titel_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPerson joakim = new MyPerson { firstName = "Joakim", lastName = "von Anka" };
            MyPerson kalle = new MyPerson { firstName = "Kalle", lastName = "Anka" };

            Console.WriteLine(kalle.GetFullName("Herr"));

            Console.WriteLine(joakim.GetFullName("Farbror"));

        }

        class MyPerson
        {
            public string firstName = "default name";
            public string lastName = "default last name";

            public string GetFullName()
            {

                return $"{firstName} {lastName}";

            }

            public string GetFullName(string epitet)
            {

                return $"{epitet} {firstName} {lastName}";

            }


        }
    }
    }

