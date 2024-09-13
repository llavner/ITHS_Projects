namespace _09._Rutig_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in höjd: ");
            string hight = Console.ReadLine();
            int pHight = Int32.Parse(hight);

            Console.Write("Mata in bredd: ");
            string width = Console.ReadLine();
            int pWidth = Int32.Parse(width);

            char character = 'X';
            //int rownumber = 0;

            for (int i = 0; i < pHight; i++)
            {
                for (int j = 1; j < pWidth; j++)
                {
                    character = CheckCharacter(character, pWidth);
                    
                }

                character = CheckCharacter(character, pWidth);

                //rownumber++;
                Console.WriteLine();
            }
        }

        static char CheckCharacter(char character, int even)
        {

            if (character == 'O')
            {
                character = 'X';
                Console.Write(character);
            }
            else
            {
                character = 'O';
                Console.Write(character);
            }

            return character;
        }
    }
}
