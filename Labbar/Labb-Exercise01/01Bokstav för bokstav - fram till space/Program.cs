namespace _01Bokstav_för_bokstav___fram_till_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World!";
            char blankSpace = ' ';

            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[i]);

                if (myString[i] == blankSpace)
                {
                    break;
                }
            }

        }
    }
}
