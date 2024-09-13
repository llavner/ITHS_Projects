using static System.Net.Mime.MediaTypeNames;

namespace _01Labb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userString = "29535123p48723487597645723645";

            int equalIndex = 0;
            ulong sumOfAllSubtrings = 0;

            for (int i = 0; i < userString.Length; i++) //yttre loop: rader
            {
                equalIndex = userString.IndexOf(userString[i], i + 1); //startar på Index 0 och jämför med nästa Index om det är lika, kör lika många gånger som myString.Length i yttre loopen.
                string subString = string.Empty; 

                for (int j = i; j <= equalIndex; j++) // Inre loop: kolumner
                {
                    if (char.IsDigit(userString[j]))
                        subString += userString[j];
                    else
                    {
                        subString = string.Empty;
                        break;
                    }
                }
                if (subString == string.Empty)
                    continue;
                Console.WriteLine(subString);
                sumOfAllSubtrings += ulong.Parse(subString); // Behandla senare, ligger på fel plats.

            }

            Console.WriteLine($"Sum of all substrings: {sumOfAllSubtrings}");
        }



    }
}
