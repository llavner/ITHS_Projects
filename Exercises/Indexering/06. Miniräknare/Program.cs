namespace _06._Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

            Console.WriteLine("Vad vill du räkna ut?");

            string input = Console.ReadLine();

            string[] splittedInput = input.Split(" ");

            int num1 = Int32.Parse(splittedInput[0]);
            int num2 = Int32.Parse(splittedInput[2]);


                Console.WriteLine($"{splittedInput[2]}");

                if (splittedInput[1] == "+")
                    Console.WriteLine(num1 + num2);

                else if (splittedInput[1] == "-")
                    Console.WriteLine(num1 - num2);

                else if (splittedInput[1] == "*")
                    Console.WriteLine(num1 * num2);
                else if (splittedInput[1] == "/")
                    Console.WriteLine(num1 / num2);
                else if (input == "")
                    break;
            }
        }
    }
}
