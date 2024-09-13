namespace _06._Bokstav_för_bokstav___grön_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            
            string subString = "oo";


            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == 'o' && text[i + 1] == 'o' && i != text.Length) // i != text.Length ser till att förhindra out of bounce.
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(subString);
                    i++; // Ökar index med en extra för substringen är två bokstäver (oo)
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(text[i]);
                }

                
                
            }
        }
    }
}
