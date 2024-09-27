namespace _08._Siffror_till_text
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skriv en funktion som tar ett heltal in, och returnerar en string[] där varje element innehåller ordet för varje siffra i talet.

            NumberToWords(654);
            
        }

        public static void NumberToWords(int number)
        {
            string[] numWords = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

         
        }
    }
}
