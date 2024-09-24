namespace _01._Skapa_en_klass_för_fordon
{
    internal partial class Program
    {
        class Vehicle
        {
            // Properties

            public string Brand { get; set; }

            public string Color { get; set; }



            // Constructor
            public Vehicle(int brand, int color)
            {

            }

            public Vehicle(int brand)
            {
                Color = "Default";
            }

        }

    }


}
