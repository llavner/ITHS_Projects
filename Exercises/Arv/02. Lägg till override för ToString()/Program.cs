using System.Drawing;

namespace _02._Lägg_till_override_för_ToString__
{
    internal class Program
    {

        //Gör en override på ToString() i Vehicle-klassen, så att "A white Toyota" skrivs ut om man kör följande kod:
        //Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));

        static void Main(string[] args)
        {
            
            Console.WriteLine(new Vehicle(Brand.Saab, Color.Yellow));

            Console.WriteLine();
        }

        class Vehicle
        {
            // Properties

            public Brand Brand { get; set; }

            public Color Color { get; set; }

            public override string ToString()
            {
                return $"A {Color} {Brand}";
                
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
