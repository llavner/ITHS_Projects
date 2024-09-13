namespace _04._Bokstav_för_bokstav___gröna_o__röda_l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello, World!";

            for (int i = 0; i < myString.Length; i++)
            {

                if (myString[i] == 'o')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('o');

                }
                else if (myString[i] == 'l')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('l');
                }
                else
                    Console.Write(myString[i]);

                Console.ResetColor();
            }
        }


    }
}
