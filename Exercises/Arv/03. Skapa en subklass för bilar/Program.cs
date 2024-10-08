﻿using System.Drawing;

namespace _03._Skapa_en_subklass_för_bilar
{
    internal class Program
    {
        //Skapa en klass Car som ärver av Vehicle. Lägg till en publik property Model, och skapa en konstruktor som initierar Brand, Model och Color.
        //"A white Yaris from Toyota" ska skrivas ut om man kör följande kod:
        //Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));


        static void Main(string[] args)
        {

            //Console.WriteLine(new Vehicle(Brand.Saab, Color.Yellow));

            Console.WriteLine(new Car(Brand.Volvo, "S90", Color.Red));
        }

        class Car : Vehicle
        {
            public string Model { get; set; }

            public Car(Brand brand, string model, Color color)
            {
                
                Model = model;

            }

            public override string ToString() // ??
            {
                return $"A {Color} {Model} from {Brand}";
            }

        }

        class Vehicle
        {
            // Properties

            public Brand Brand { get; set; }

            public Color Color { get; set; }

            public override string ToString()
            {
                return $"A {Color}{Brand}";

            }

            // Constructor
            public Vehicle(Brand brand, Color color)
            {
                Brand = brand;
                Color = color;
            }

            public Vehicle(Brand brand)
            {
                Color = Color.Green;
            }

            public Vehicle()
            {

            }

        }

        public enum Brand
        {
            Volvo,
            BMW,
            Saab,
            Dodge
        }

        public enum Color
        {
            Red,
            Blue,
            Green,
            Brown,
            Yellow

        }
    }
}
