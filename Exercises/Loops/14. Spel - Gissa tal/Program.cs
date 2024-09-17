namespace _14._Spel___Gissa_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNum = random.Next(1, 100);
            int counter = 1;

            Console.Write("Gissa ett tal mellan 1 - 100: ");
            int num = Int32.Parse(Console.ReadLine());

            while (num != randomNum)
            {
                if (num < randomNum)
                    Console.Write("To low, try again: ");
                if (num > randomNum)
                    Console.Write("To high, try again: ");

                counter++;

                num = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Congratulations!");
            Console.WriteLine($"You guess the right number in: {counter} attempts.");




        }
    }
}
