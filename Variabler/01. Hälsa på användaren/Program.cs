namespace _01._Hälsa_på_användaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hej {name}!");
        }
    }
}
