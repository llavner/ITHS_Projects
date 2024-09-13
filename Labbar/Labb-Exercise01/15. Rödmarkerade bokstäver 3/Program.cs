namespace _15._Rödmarkerade_bokstäver_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "ajdfhvajhdfd";

            int equalIndex = 0;
            int startIndex = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[0] && i > 0)
                {
                    equalIndex = i;
                    break;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++) 
                {
                    if (j >= startIndex && j <= equalIndex) // startIndex och equalIndex håller koll på var bokstäverna färgas röda.
                        Console.ForegroundColor = ConsoleColor.Red;
                    
                    else if (j >= text.Length)
                        break;
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write(text[j]);
                    Console.ForegroundColor = ConsoleColor.Gray;

                }

                // Incrementerar för att flytta indexet framåt.

                startIndex++;
                equalIndex++;
                Console.WriteLine();
                

            }
        }
    }
}
