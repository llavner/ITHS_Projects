using System;

namespace _13._Rödmarkerade_bokstäver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefghijklmnopqrstuvwxyz";


            for (int i = 0; i < text.Length; i++)// yttre loop: Raden
            {

                for (int j = 0; j < text.Length; j++) // inre loop: Kolumnen
                {

                    if (j >= i && j <= i + 4) // Så länge j är större eller lika med i OCH j är mindre eller likamed i + 4 skriver den röd bokstav.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write(text[j]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();

            }

        }
    }
}
