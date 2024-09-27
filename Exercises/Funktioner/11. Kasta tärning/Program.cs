using System;

namespace _11._Kasta_tärning
{
    internal class Program
    {

        //Skriv en funktion ThrowDice() som returnerar ett slumpmässigt heltal 1-6. Skriv en annan funktion
        //ThrowMultipleDice(int n) som returnerarresultatet av att man slagit n tärningar.

        //Extra utmaning: Lägg till en frivillig(optional) int på båda funktionerna, där man kan ange antal sidor på tärningen(default 6).
        //Tips: Kolla exempelkoden för Random.Next() för att få ut slumpmässiga heltal.


        static void Main(string[] args)
        {
            int dices;
            int sides;
            string input, input2 = "";

            
            
            Console.WriteLine("Enter number of dices: ");
            input = Console.ReadLine();
            int.TryParse(input, out dices);

            Console.WriteLine("Enter number of sides on the dice: ");
            input2 = Console.ReadLine();
            int.TryParse(input2, out sides);

            Console.WriteLine($"Your result with {dices} dices with {sides} sides is: {ThrowDice(dices)}");
            

        }

        public static int ThrowDice(int dices, int sides = 6)
        {
            Random rand = new Random();

            int diceResult = dices * (rand.Next(1, sides));

            return diceResult;

        }
    }
}

