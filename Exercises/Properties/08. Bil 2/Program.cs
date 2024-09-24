using System.Diagnostics.Metrics;
using System;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace _08._Bil_2
{
    internal class Program
    {
        //Skriv en ny klass som representerar en bil.Varje bil ska kunna ha en färg som representeras av en ConsoleColor, samt en längd.
        //När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
        //Instansiera 1000 bilar och spara i en array.Skapa en funktion som tar en array av bilar och returnerar den sammanlagda längden av alla gröna bilar.

        static void Main(string[] args)
        {
            Car[] cars = new Car[1000];


            for (int i = 0; i < 1000; i++)
            {
                cars[i] = new Car();
            }

            Console.WriteLine($"The sum of the length of all green cars is: {LengthSum(cars)}");

            int LengthSum(Car[] cars)
            {
                int sumOfAllGreen = 0;

                foreach (Car car in cars)
                {
                    if (car.Color == ConsoleColor.Green)
                    {
                        sumOfAllGreen += car.Length;
                    }
                }

                return sumOfAllGreen;

            }
        }

        class Car
        {
            Random random = new Random();
            public ConsoleColor Color { get; set; }

            public int Length { get; set; }

            public Car()
            {
                Length = random.Next(3, 5);
                Color = (ConsoleColor)random.Next(0, 15);

            }

        }
    }
}
