namespace _07._Modifiera_utskrift_med_lambdauttryck
{

    //Skriv en metod som tar en string[] som inparameter och skriver ut alla strängar i arrayen på varsin rad.
    //Uppdatera sedan metoden så att den tar en andra parameter:

    //Func<string, string> modifier, och anropa modifier() på varje string i arrayen innan du skriver ut den.
    //Skapa en en string[] med namnen på fem städer som du kan skicka in i metoden.

    //Gör 3 anrop till metoden (med olika lambda-uttryck):

    //Ett som skriver ut alla städer i UPPERCASE
    //Ett som skriver ut de 3 första tecknen i varje stad
    //Ett som skriver ut längden på varje stads namn.

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = ["Sweden", "Noway", "Denmark", "Finland", "Iceland"];

            //Func<string, string> modifier = city => city.ToUpper();

            //Func<string, string> modifier = city => city.Substring(0, 3);

            Func<string, string> modifier = city => city.Length.ToString();

            PrintArrays(cities, modifier);

        }

        public static void PrintArrays(string[] array, Func<string,string> myDelegate)
        {

            foreach (var item in array)
            {
                Console.WriteLine(myDelegate(item));
            }

        }
    }
}
