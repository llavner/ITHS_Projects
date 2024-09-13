using System;

namespace _14._Rödmarkerade_bokstäver_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            int equalIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[0] && i > 0)
                {
                    equalIndex = i; //Tar reda på vart index är lika
                    break;
                }
            }


            for (int i = 0; i < text.Length; i++) 
            {
                if (i <=  equalIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.Write(text[i]);
            }
        }
    }
}
