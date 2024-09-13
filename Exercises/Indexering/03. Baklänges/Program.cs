namespace _03._Baklänges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Skriv en text: ");

            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);

            string reversedInput = new string(inputArray);

            Console.WriteLine(reversedInput);
        }
    }
}
