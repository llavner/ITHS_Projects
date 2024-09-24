namespace _05._Initiera_i_Vehicle__skriv_ut_i_Car_
{
    internal partial class Program
    {
        class Car : Vehicle
        {
            public string Model { get; set; }

            
            
            public Car(Brand brand, string model, Color color) : base (brand, color)
            {
                Model = model;
            }

            public override string ToString()
            {
                return $"A {Color}, with the length of {Size.Length} m, {Model} from {Brand}";
            }

        }
    }
}

