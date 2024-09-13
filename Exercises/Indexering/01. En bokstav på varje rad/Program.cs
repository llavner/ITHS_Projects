namespace _01._En_bokstav_på_varje_rad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv något: ");

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
