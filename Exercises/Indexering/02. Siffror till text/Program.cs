namespace _02._Siffror_till_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", "tio" };

            Console.Write("Skriv en siffra: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    {
                        Console.WriteLine(numbers[0]);
                        break;
                    }
                case "1":
                    {
                        Console.WriteLine(numbers[1]);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine(numbers[2]);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine(numbers[3]);
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine(numbers[4]);
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine(numbers[5]);
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine(numbers[6]);
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine(numbers[7]);
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine(numbers[8]);
                        break;
                    }
                case "9":
                    {
                        Console.WriteLine(numbers[9]);
                        break;
                    }
            }
        }
    }
}
