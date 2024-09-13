namespace _2._Bokstav_för_bokstav___radbyte_på_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is just some other text";
            char blankSpace = ' ';

            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[i]);

                if (myString[i] == blankSpace)
                    Console.WriteLine();
                
            }
        }
    }
}
