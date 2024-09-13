namespace _05._Palindrom
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

            if (reversedInput == input)
                Console.WriteLine($"{input} är ett palindrom.");
            else
                Console.WriteLine($"{input} är inte ett palindrom.");
        }
    }
}
