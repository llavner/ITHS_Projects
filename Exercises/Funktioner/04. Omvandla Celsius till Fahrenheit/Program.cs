using Microsoft.VisualBasic;

namespace _04._Omvandla_Celsius_till_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0;
            double fahrenheit = 0;
            string input = null;

            while (true)
            {
                if (input == "x")
                    break;

                Console.Write("Enter Celsius(x to exit): ");
                input = Console.ReadLine().ToLower();

                while (!double.TryParse(input, out celsius))
                {
                    if (input == "x")
                        break;

                    Console.Write("Wrong input, try again: ");
                    input = Console.ReadLine();
                }
                if (input != "x")
                {
                    fahrenheit = ConvertCelsius(celsius);
                    Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit.");
                    Console.WriteLine();
                }

            }       

        }

        static double ConvertCelsius(double celsius)
        {  

            double conversion = (celsius * 9/5) + 32;

            return conversion;
        }
    }
}
