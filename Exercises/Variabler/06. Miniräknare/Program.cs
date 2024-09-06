namespace _06._Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in första talet: ");
            string tal1 = Console.ReadLine();

            Console.WriteLine("Välj +, -, * eller /: ");
            string option = Console.ReadLine();

            Console.WriteLine("Skriv in andra talet: ");
            string tal2 = Console.ReadLine();



            switch (option)
            {
                case "+":
                    {
                        int sum = int.Parse(tal1) + int.Parse(tal2);
                        Console.WriteLine($"{tal1} + {tal2} = {sum}");
                        return;
                    }
                case "-":
                    {
                        int sum = int.Parse(tal1) - int.Parse(tal2);
                        Console.WriteLine($"{tal1} - {tal2} = {sum}");
                        return;
                    }
                case "*":
                    {
                        int sum = int.Parse(tal1) * int.Parse(tal2);
                        Console.WriteLine($"{tal1} * {tal2} = {sum}");
                        return;
                    }
                case "/":
                    {
                        int sum = int.Parse(tal1) / int.Parse(tal2);
                        Console.WriteLine($"{tal1} / {tal2} = {sum}");
                        return;
                    }
                default:
                    Console.WriteLine("Wrong input");
                    return;
            }
        }
    }
}
