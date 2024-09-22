using System.Collections.Generic;
using System.Reflection.Metadata;
using System;

namespace _05._Bil
{
    internal class Program
    {

        //Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg. Skapa publika properties för att hämta eller ändra värdet på varje field.
        //Skriv en konstruktor till bilklassen som inte tar några parametrar.Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa.
        
        //Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

        //Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på bilen sänkas till hälften.
        static void Main(string[] args)
        {

            Car carOne = new Car(theModel: "Volvo", theColor: "Red", thePrice: 50000); //Här styr jag att konstruktorn med värden används

            Car carTwo = new Car(); // För carTwo används den tomma konstruktorn.

            Console.WriteLine($"My {carOne.Model} is {carOne.Color} cost: {carOne.Price}");
            Console.WriteLine($"My {carTwo.Model} is {carTwo.Color} cost: {carTwo.Price}");

            Console.WriteLine(carOne.HalfPrice());

        }
    }
}
