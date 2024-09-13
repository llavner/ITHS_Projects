namespace _07._Bokstav_för_bokstav___grön_substring_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string subString = "chuck";

            for (int i = 0; i < text.Length; i++)
            {
                int charIndex = text.IndexOf(subString, i);

                if (i == charIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(subString);
                    i += 4;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(text[i]);
                }

                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
