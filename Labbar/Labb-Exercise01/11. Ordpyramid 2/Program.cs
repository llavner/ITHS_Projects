namespace _11._Ordpyramid_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

            string[] textSplit = text.Split(); // Splittar upp strängens ord till en array av 13 substrängar.

            string joinedText = string.Empty;

            
            foreach (string item in textSplit)
            {
                joinedText += item + " "; // += lägger till joinedText med Item för varje iteration, joinText blir först "How" sen += "How much" sen "How much wood" osv.
                Console.WriteLine(joinedText);
            }

            /*
            Med en for-loop:
            for (int i = 0; i < textSplit.Length; i++)
            {

                joinedText = string.Join(" ", textSplit, 0, i + 1);
                Console.WriteLine(joinedText);
            }*/
        }
    }
}
  