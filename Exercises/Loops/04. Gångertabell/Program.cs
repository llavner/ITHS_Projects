namespace _04._Gångertabell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal: ");
            string input = Console.ReadLine();

            int num = int.Parse(input);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
            }
        }
    }
}
