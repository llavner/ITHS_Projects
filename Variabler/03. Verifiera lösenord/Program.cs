namespace _03._Verifiera_lösenord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pinCode = "admin123";

            Console.WriteLine("Skriv in ditt lösenord: ");
            string input = Console.ReadLine();
            while (input != pinCode)
            {
                if (input != pinCode)
                {
                    Console.WriteLine("Fel lösenord, försök igen.");
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine("Välkommen in.");
            Console.WriteLine();
        }
    }
}
