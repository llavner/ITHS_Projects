namespace _13._Flytta_runt_ett___med_piltangenterna_
{
    internal class Program
    {

        //Låt oss skriva början till ett enkelt spel:
        //Använd DrawBox-funktionen i föregående uppgift för att rita en box på skärmen.
        //Placera sedan ett @ i mitten av boxen.Om man använder piltangenterna ska man kunna flytta runt @.
        //När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.

        //Tips: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen. Spara bredd och höjd på boxen så du vet när den ska stanna.
        //Tips: Kolla upp Console.ReadKey(); och Console.KeyAvailable;


        static void Main(string[] args)
        {

            int boxWidth = 40;
            int boxHeight = 20;
            char player = '@';




            for (int i = 0; i < boxHeight; i++)
            {



                for (int j = 0; j < boxWidth; j++)
                {
                    if (i == 0 || i == boxHeight - 1 || j == 0 || j == boxWidth - 1)
                        Console.Write("#");
                    else if (i == 0 || i != boxHeight / 2 || j == 0 || j != boxWidth / 2)
                        Console.Write(" ");
                    else
                        Console.Write(player);
                }


                Console.WriteLine();

            }

            int horisont = 20;
            int vertical = 10;

            do // Game Loop
            {
                Console.CursorVisible = false;

                if(Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    horisont--;
                    Console.SetCursorPosition(horisont,vertical);
                    Console.Write(player);

                }
                if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    horisont++;
                    Console.SetCursorPosition(horisont, vertical);
                    Console.Write(player);

                }
                if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    vertical--;
                    Console.SetCursorPosition(horisont, vertical);
                    Console.Write(player);

                }
                if (Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    vertical++;
                    Console.SetCursorPosition(horisont, vertical);
                    Console.Write(player);

                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
