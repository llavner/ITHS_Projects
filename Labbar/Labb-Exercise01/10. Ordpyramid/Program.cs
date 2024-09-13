namespace _10._Ordpyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

            string[] textSplit = text.Split(' '); // Splittar upp strängens ord till en array.
            
            for (int i = 0; i < textSplit.Length; i++) // 13
            {
                if(i != textSplit.Length)
                {
                    for (int j = 0; j < i + 1; j++)
                        Console.Write(textSplit[i] + " "); // Hårdkodat mellanslag
                }

            Console.WriteLine();
            }
        }
    }
}
