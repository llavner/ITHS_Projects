using System.ComponentModel.DataAnnotations;

namespace _04._Skapa_en_struct_för_att_spara_längd__bredd_och_höjd_
{
    internal class Program
    {

        // Skapa en struct Size med properties Length, Width och Height; samt en konstruktor som tar 3 argument för att initiera dessa.
        static void Main(string[] args)
        {

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

            public Vehicle(Size size)
            {

            }
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

        struct Size
        {
            public double Length, Width, Height;
            
           /* public Size(double length, double width, double height)
            {
                Length = length;
                Width = width;
                Height = height;
            }*/
            
        }
    }
}
