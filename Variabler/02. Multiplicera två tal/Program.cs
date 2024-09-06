using System;

namespace _02._Multiplicera_två_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in första talet: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Skriv in andra talet: ");
            string num2 = Console.ReadLine();

            int sum = Int32.Parse(num1) * Int32.Parse(num2);
            Console.WriteLine($"{num1} * {num2} = {sum}");
        
        }
    }
}
