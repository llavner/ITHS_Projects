namespace _05._Initiera_i_Vehicle__skriv_ut_i_Car_
{
    internal partial class Program
    {
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
    }
}

