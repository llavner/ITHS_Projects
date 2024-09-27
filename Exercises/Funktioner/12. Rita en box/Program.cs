using System;

namespace _12._Rita_en_box
{
    internal class Program
    {

        //Skriv en funktion DrawBox(int width, int height). När man anropar funktionen ska den skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’.

        //Exempel: DrawBox(7, 4);

        //Extrauppgift: Uppdatera funktionen och lägg till parametrar left och top (för positionen på översta vänstra hörnet av boxen.
        //Skriv en loop som printar ut rektanglar med random storlek och position på skärmen.

        //Tips: Använd Console.SetCursorPosition(); för att flytta Cursorn, d.v.s var nästa tecken ska skrivas.
        //Om du vill kan du även dölja cursorn genom att sätta Console.CursorVisible = false;

        //Tips: Använd Thread.Sleep(n); för att lägga in en fördröjning på n millisekunder innan nästa rektangel ritas ut.

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                DrawBox();
                Thread.Sleep(500);


            } while (true);

        }

        public static void DrawBox()
        {

            var random = new Random();

            int left = random.Next(20, 50);
            int top = random.Next(5, 20);
            int width = random.Next(10, 20);
            int height = random.Next(5, 15);

            Console.SetCursorPosition(left, top);
            Console.CursorVisible = false;

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                        Console.Write("#");
                    else
                        Console.Write("-");
                }
                 
                Console.WriteLine();
                top++;
                Console.SetCursorPosition(left, top);

            }


        }
    }
}
