namespace _08._Bokstav_för_bokstav___grön_substring_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter substring: ");
            string subString = Console.ReadLine();

            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

            bool contains = text.Contains(subString); // Kollar om substrängen finns i texten, returnerar en true/false

            for (int i = 0; i < text.Length; i++)
            {
                int charIndex = text.IndexOf(subString, i); // Kollar var substrängen börjar och skriver ut index där den stöter på substrängen först??

                if (i == charIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(subString);
                    i += subString.Length - 1;
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
