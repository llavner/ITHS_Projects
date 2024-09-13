using System;

namespace _12._Rödmarkerade_ord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string[] textSplit = text.Split(' ');
            
            for (int i = 0; i < textSplit.Length; i++)// yttre loop
            {

                for (int j = 0; j < textSplit.Length; j++) // inre loop
                {

                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(textSplit[j] + " ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(textSplit[j] + " ");
                    }
                    
                }
                Console.WriteLine();

            }
        }
    }
}
