namespace _05._Dubblera_och_halvera_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal: ");
            string input = Console.ReadLine();

            int num = int.Parse(input);

            int dubblera = num * 2;
            int halvera = num / 2;

            Console.WriteLine($"{dubblera} är dubbelt så mycket som {num}.\n{halvera} är hälften så mycket av {num}.");
        }
    }
}
