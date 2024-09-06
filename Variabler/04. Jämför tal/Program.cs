using System;

namespace _04._Jämför_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal: ");
            string input = Console.ReadLine();

            int parsedInt = int.Parse(input);

            if (parsedInt < 100)
                Console.WriteLine("Ditt tal är mindre än 100.");
            else if (parsedInt == 100)
                Console.WriteLine("Ditt tal är lika med 100.");
            else
                Console.WriteLine("Ditt tal är större än 100.");
        }
    }
}
